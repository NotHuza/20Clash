using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Login
{
    public class KeepAliveMessage : PiranhaMessage
    {
        public KeepAliveMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public override async void Process()
        {
            await new KeepAliveOkMessage(Device).SendAsync();
        }
    }
}