using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server
{
    public class DisconnectedMessage : PiranhaMessage
    {
        public DisconnectedMessage(Device device) : base(device)
        {
            Id = 25892;
        }

        public override void Encode()
        {
            Writer.WriteInt(1);
        }
    }
}