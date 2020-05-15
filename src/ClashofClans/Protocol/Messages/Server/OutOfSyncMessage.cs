using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server
{
    public class OutOfSyncMessage : PiranhaMessage
    {
        public OutOfSyncMessage(Device device) : base(device)
        {
            Id = 24104;
        }

        public override void Encode()
        {
            Writer.WriteInt(0);
            Writer.WriteInt(0);
            Writer.WriteInt(0);
        }
    }
}