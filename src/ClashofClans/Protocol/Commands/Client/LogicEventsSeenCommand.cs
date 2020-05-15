using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicEventsSeenCommand : LogicCommand
    {
        public LogicEventsSeenCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public override void Decode()
        {
            Reader.ReadInt(); // Count?

            base.Decode();
        }
    }
}