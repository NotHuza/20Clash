using ClashofClans.Logic;
using ClashofClans.Utilities.Utils;

namespace ClashofClans.Protocol.Messages.Server
{
    public class VisitedHomeDataMessage : PiranhaMessage
    {
        public VisitedHomeDataMessage(Device device) : base(device)
        {
            Id = 24113;
            Device.CurrentState = Device.State.Visit;
        }

        public Player Player { get; set; }

        public override void Encode()
        {
            if (Player == null)
                return;

            Writer.WriteInt(TimeUtils.CurrentUnixTimestamp);

            Player.LogicClientHome(Writer);
            Player.LogicClientAvatar(Writer);

            Writer.WriteInt(0);

            Writer.WriteBoolean(true);
            Device.Player.LogicClientAvatar(Writer);
        }
    }
}