using System;
using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server.Ranking
{
    public class AvatarRankingListMessage : PiranhaMessage
    {
        public AvatarRankingListMessage(Device device) : base(device)
        {
            Id = 24403;
        }

        public override void Encode()
        {
            Writer.WriteInt(0);

            Writer.WriteInt(0);
            Writer.WriteInt((int) TimeSpan.FromDays(1).TotalSeconds);
            Writer.WriteInt(DateTime.UtcNow.Year);
            Writer.WriteInt(DateTime.UtcNow.Month);
            Writer.WriteInt(DateTime.UtcNow.Year);
            Writer.WriteInt(DateTime.UtcNow.Month - 1);
        }
    }
}