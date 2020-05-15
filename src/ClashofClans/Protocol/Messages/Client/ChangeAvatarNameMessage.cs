using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client
{
    public class ChangeAvatarNameMessage : PiranhaMessage
    {
        public ChangeAvatarNameMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.Home;
        }

        public string Name { get; set; }

        public override void Decode()
        {
            Name = Reader.ReadScString();
        }

        public override async void Process()
        {
            if (Name.Length >= 3 && Name.Length <= 15)
            {
                var home = Device.Player.Home;

                if (home.NameSet < 2)
                {
                    home.Name = Name;
                    home.NameSet++;

                    /*await new AvailableServerCommandMessage(Device)
                    {
                        Command = new LogicChangeAvatarName(Device)
                        {
                            Name = Name
                        }.Handle()
                    }.SendAsync();*/

                    // SKIP MISSIONS
                    await new OwnHomeDataMessage(Device).SendAsync();
                }
                else
                {
                    Device.Disconnect("Can't change mame anymore.");
                }
            }
            else
            {
                Device.Disconnect("Invalid name.");
            }
        }
    }
}