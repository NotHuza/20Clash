using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicCollectAchievementCommand : LogicCommand
    {
        public LogicCollectAchievementCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int AchievementId { get; set; }

        public override void Decode()
        {
            AchievementId = Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            Device.Disconnect("Not implemented.");
        }
    }
}