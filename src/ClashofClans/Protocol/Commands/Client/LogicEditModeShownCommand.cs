using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicEditModeShownCommand : LogicCommand
    {
        public LogicEditModeShownCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }
    }
}