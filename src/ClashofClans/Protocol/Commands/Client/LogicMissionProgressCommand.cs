using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicMissionProgressCommand : LogicCommand
    {
        public LogicMissionProgressCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int MissionId { get; set; }

        public override void Decode()
        {
            MissionId = Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            Device.Disconnect($"Mission {MissionId % 21000000} completed.");

            // TODO
        }
    }
}