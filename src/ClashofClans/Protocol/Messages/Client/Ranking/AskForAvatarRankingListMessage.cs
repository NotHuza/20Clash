using System;
using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server.Ranking;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Ranking
{
    public class AskForAvatarRankingListMessage : PiranhaMessage
    {
        public AskForAvatarRankingListMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public override async void Process()
        {
            await new AvatarRankingListMessage(Device).SendAsync();
        }
    }
}