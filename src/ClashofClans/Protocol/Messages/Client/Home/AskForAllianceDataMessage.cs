using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Home
{
    public class AskForAllianceDataMessage : PiranhaMessage
    {
        public AskForAllianceDataMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public long AllianceId { get; set; }

        public override void Decode()
        {
            AllianceId = Reader.ReadLong();
        }

        public override async void Process()
        {
            await new AllianceDataMessage(Device).SendAsync();
        }
    }
}