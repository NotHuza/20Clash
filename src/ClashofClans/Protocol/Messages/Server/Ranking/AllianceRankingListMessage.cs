using System;
using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server.Ranking
{
    public class AllianceRankingListMessage : PiranhaMessage
    {
        public AllianceRankingListMessage(Device device) : base(device)
        {
            Id = 24401;
        }

        public override void Encode()
        {
            Writer.WriteInt(0);

            Writer.WriteInt((int) TimeSpan.FromDays(1).TotalSeconds);

            Writer.WriteInt(3); // Reward Count
            Writer.WriteInt(100000); // #1 Reward
            Writer.WriteInt(10000); // #2 Reward
            Writer.WriteInt(1000); // #3 Reward
        }
    }
}