using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicAcceptChatRulesCommand : LogicCommand
    {
        public LogicAcceptChatRulesCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public override void Decode()
        {
            Reader.ReadInt();
            Reader.ReadByte();

            base.Decode();
        }
    }
}