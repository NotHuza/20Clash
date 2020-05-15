using System;
using System.Globalization;
using ClashofClans.Logic;
using ClashofClans.Logic.Sessions;
using ClashofClans.Protocol.Messages.Server;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Login
{
    public class LoginMessage : PiranhaMessage
    {
        public LoginMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            device.CurrentState = Device.State.Login;
            RequiredState = Device.State.Login;
        }

        public long UserId { get; set; }
        public string UserToken { get; set; }
        public int ClientMajorVersion { get; set; }
        public int ClientBuild { get; set; }
        public int ClientMinorVersion { get; set; }
        public string FingerprintSha { get; set; }
        public string PreferredDeviceLanguage { get; set; }
        public uint Seed { get; set; }

        public override void Decode()
        {
            UserId = Reader.ReadLong();
            UserToken = Reader.ReadScString();

            ClientMajorVersion = Reader.ReadInt();
            ClientMinorVersion = Reader.ReadInt();
            ClientBuild = Reader.ReadInt();

            FingerprintSha = Reader.ReadScString();

            Reader.ReadScString(); // empty
            Reader.ReadScString();
            Reader.ReadScString(); // empty
            Reader.ReadScString(); // Device

            Reader.ReadInt();

            PreferredDeviceLanguage = Reader.ReadScString().Substring(3, 2); // Language
            Reader.ReadScString();
            Reader.ReadScString(); // 10

            Reader.ReadByte();

            Reader.ReadScString();
            Reader.ReadScString();
            Reader.ReadScString();

            Reader.ReadByte();
            Reader.ReadScString();

            Seed = Reader.ReadUnsignedInt();
        }

        public override async void Process()
        {
            var player = await Resources.Players.Login(UserId, UserToken);

            if (player != null)
            {
                Device.Player = player;
                player.Device = Device;

                await new LoginOkMessage(Device).SendAsync();

                var ip = Device.GetIp();

                if (UserId <= 0) player.Home.CreatedIpAddress = ip;

                Device.Player.Home.PreferredDeviceLanguage = PreferredDeviceLanguage;

                var session = Device.Session;
                session.Ip = ip;
                session.GameVersion = $"{ClientMajorVersion}.{ClientMinorVersion}";
                session.Location = await Location.GetByIpAsync(ip);
                session.SessionId = Guid.NewGuid().ToString();
                session.StartDate = session.SessionStart.ToString(CultureInfo.InvariantCulture);

                player.Home.TotalSessions++;

                // TESTING:
                player.Home.FastForward((int) DateTime.UtcNow.Subtract(player.Home.LastSaveTime).TotalSeconds);
                
                await new OwnHomeDataMessage(Device).SendAsync();
                //await new AvatarStreamMessage(Device).SendAsync();
            }
            else
            {
                await new LoginFailedMessage(Device)
                {
                    Reason = "Account not found. Please clear app data."
                }.SendAsync();
            }
        }
    }
}