using ClashofClans.Logic;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Protocol.Messages.Server
{
    public class KeepAliveOkMessage : PiranhaMessage
    {
        public KeepAliveOkMessage(Device device) : base(device)
        {
            Id = 20108;
        }

        public override void Encode()
        {
            Writer.WriteHex("FFFF0000000000");
        }
    }
}