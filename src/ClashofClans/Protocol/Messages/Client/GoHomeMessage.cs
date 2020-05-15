using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client
{
    public class GoHomeMessage : PiranhaMessage
    {
        public GoHomeMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public override void Decode()
        {
            Reader.ReadByte(); // 4
            Reader.ReadInt(); // 2
            Reader.ReadInt(); // 0
        }

        public override async void Process()
        {
            if (Device.CurrentState != Device.State.Home)
                await new OwnHomeDataMessage(Device).SendAsync();
            else
                Device.Disconnect("Invalid state!");
        }
    }
}