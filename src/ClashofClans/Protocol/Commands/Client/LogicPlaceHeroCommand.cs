using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicPlaceHeroCommand : LogicCommand
    {
        public LogicPlaceHeroCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public override void Decode()
        {
            Reader.ReadInt(); // X
            Reader.ReadInt(); // Y

            Reader.ReadInt(); // HeroId

            base.Decode();
        }

        public override void Process()
        {
            // TODO
        }
    }
}