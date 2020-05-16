using ClashofClans.Logic;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Protocol.Messages.Server
{
    public class AllianceDataMessage : PiranhaMessage
    {
        public AllianceDataMessage(Device device) : base(device)
        {
            Id = 25413;
        }

        public override void Encode()
        {
            Writer.WriteLong(1); // AllianceId
            Writer.WriteScString("Test"); // Name
            Writer.WriteInt(0); // Badge
            Writer.WriteInt(1); // Type
            Writer.WriteInt(0); // Members

            Writer.WriteInt(1000); // Score
            Writer.WriteInt(500); // DuelScore

            Writer.WriteInt(0); // RequiredScore
            Writer.WriteInt(0); // RequiredDuelScore

            Writer.WriteInt(0); // RequiredTownhallLevel

            Writer.WriteInt(1); // WonWarCount
            Writer.WriteInt(2); // LostWarCount
            Writer.WriteInt(3); // DrawWarCount

            Writer.WriteInt(0); // Region

            Writer.WriteInt(0); // WarFrequency
            Writer.WriteInt(0); 

            Writer.WriteInt(0); // ExpPoints
            Writer.WriteInt(12); // ExpLevel

            Writer.WriteInt(0); // WarWinStreak

            Writer.WriteInt(16777216);
            Writer.WriteInt(16842752);
            Writer.WriteInt(0); // CWL

            Writer.WriteBoolean(true); // PublicWarLog ?
            Writer.WriteBoolean(true); // FriendlyWar ?

            Writer.WriteScString("Test");
            Writer.WriteBoolean(false);
            Writer.WriteInt(0);
            Writer.WriteInt(0);
            Writer.WriteInt(0);
            Writer.WriteInt(0);
        }
    }
}
