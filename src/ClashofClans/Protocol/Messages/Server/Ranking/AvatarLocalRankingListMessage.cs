using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server.Ranking
{
    public class AvatarLocalRankingListMessage : PiranhaMessage
    {
        public AvatarLocalRankingListMessage(Device device) : base(device)
        {
            Id = 24404;
        }

        public override void Encode()
        {
            Writer.WriteInt(0);
        }
    }
}