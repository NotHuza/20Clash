using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server
{
    public class AvatarStreamMessage : PiranhaMessage
    {
        public AvatarStreamMessage(Device device) : base(device)
        {
            Id = 24411;
        }

        public override void Encode()
        {
            Writer.WriteInt(0);
        }
    }
}