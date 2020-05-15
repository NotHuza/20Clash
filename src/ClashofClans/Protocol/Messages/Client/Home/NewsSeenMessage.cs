using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Home
{
    public class NewsSeenMessage : PiranhaMessage
    {
        public NewsSeenMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public override void Decode()
        {
            Reader.ReadByte();
        }
    }
}