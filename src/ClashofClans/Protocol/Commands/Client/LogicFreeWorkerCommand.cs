using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicFreeWorkerCommand : LogicCommand
    {
        public LogicFreeWorkerCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int SecondLeft { get; set; }
        public bool CommandEmbed { get; set; }

        public override void Decode()
        {
            SecondLeft = Reader.ReadInt();
            CommandEmbed = Reader.ReadBoolean();
            base.Decode();
        }

        public override void Process()
        {
            Device.Disconnect($"Not implemented.\n\nIs command embed: {CommandEmbed}, Seconds left: {SecondLeft}");
        }
    }
}