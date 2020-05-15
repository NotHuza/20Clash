using ClashofClans.Logic;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Protocol.Messages.Server
{
    public class GlobalChatLineMessage : PiranhaMessage
    {
        public GlobalChatLineMessage(Device device) : base(device)
        {
            Id = 24715;
        }

        public string Message { get; set; }

        public override void Encode()
        {
            Writer.WriteScString(Message);

            var home = Device.Player.Home;

            Writer.WriteScString(home.Name);
            Writer.WriteInt(home.ExpLevel);
            Writer.WriteInt(0);

            Writer.WriteLong(home.Id);
            Writer.WriteLong(home.Id);

            Writer.WriteBoolean(false);
        }
    }
}