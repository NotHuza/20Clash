using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server.Ranking
{
    public class AllianceLocalRankingListMessage : PiranhaMessage
    {
        public AllianceLocalRankingListMessage(Device device) : base(device)
        {
            Id = 24402;
        }

        public override void Encode()
        {
            Writer.WriteInt(0);
        }
    }
}