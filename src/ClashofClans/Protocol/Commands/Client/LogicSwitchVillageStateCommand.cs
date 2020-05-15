using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicSwitchVillageStateCommand : LogicCommand
    {
        public LogicSwitchVillageStateCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int State { get; set; }

        public override void Decode()
        {
            State = Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            Device.Player.Home.State = State;
        }
    }
}