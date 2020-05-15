using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicNewsSeenCommand : LogicCommand
    {
        public LogicNewsSeenCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int NewsId { get; set; }

        public override void Decode()
        {
            NewsId = Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            Device.Player.Home.GameObjectManager.LastNewsSeen = NewsId;
        }
    }
}