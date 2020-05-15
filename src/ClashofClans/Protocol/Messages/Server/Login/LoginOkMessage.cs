using ClashofClans.Logic;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Protocol.Messages.Server
{
    public class LoginOkMessage : PiranhaMessage
    {
        public LoginOkMessage(Device device) : base(device)
        {
            Id = 23654;
            Version = 1;
        }

        public override void Encode()
        {
            var home = Device.Player.Home;

            Writer.WriteLong(home.Id);
            Writer.WriteLong(home.Id);

            Writer.WriteScString(Device.Player.Home.UserToken);

            Writer.WriteScString(string.Empty); // FB Id
            Writer.WriteScString("G:1"); // GP Id

            Writer.WriteInt(Resources.Fingerprint.GetMajorVersion);
            Writer.WriteInt(Resources.Fingerprint.GetBuildVersion);
            Writer.WriteInt(Resources.Fingerprint.GetContentVersion);

            Writer.WriteScString("prod");

            Writer.WriteInt(1); // SessionCount
            Writer.WriteInt(0); // PlayTime
            Writer.WriteInt(0); // DaysSinceStartedPlaying

            Writer.WriteScString(string.Empty);
            Writer.WriteScString("0"); // Server Time
            Writer.WriteScString("0"); // Account Creation Date

            Writer.WriteInt(0); // StartupCooldownSeconds

            Writer.WriteScString(null); // Google Service Id
            Writer.WriteScString("DE");
            Writer.WriteScString(null);

            Writer.WriteInt(1);
            Writer.WriteScString(null);
            Writer.WriteScString(null);
            Writer.WriteScString(null);

            Writer.WriteInt(1);
            Writer.WriteScString("https://game-assets.clashofclans.com/");

            Writer.WriteInt(1);
            Writer.WriteScString("https://event-assets.clashofclans.com");

            Writer.WriteHex("FFFFFFFF0100FFFFFFFF");
        }
    }
}