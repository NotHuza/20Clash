using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client
{
    public class SetDeviceTokenMessage : PiranhaMessage
    {
        public SetDeviceTokenMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }
    }
}