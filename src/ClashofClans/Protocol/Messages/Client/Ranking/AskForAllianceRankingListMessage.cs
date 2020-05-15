using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server.Ranking;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Ranking
{
    public class AskForAllianceRankingListMessage : PiranhaMessage
    {
        public AskForAllianceRankingListMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public bool IsLocal { get; set; }

        public override void Decode()
        {
            IsLocal = Reader.ReadBoolean();
            Reader.ReadInt();
        }

        public override async void Process()
        {
            if (IsLocal)
                await new AllianceLocalRankingListMessage(Device).SendAsync();
            else
                await new AllianceRankingListMessage(Device).SendAsync();
        }
    }
}