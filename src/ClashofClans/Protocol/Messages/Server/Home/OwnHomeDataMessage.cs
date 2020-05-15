using System;
using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server
{
    public class OwnHomeDataMessage : PiranhaMessage
    {
        public OwnHomeDataMessage(Device device) : base(device)
        {
            Id = 25195;
            device.CurrentState = Device.State.Home;
            Device.LastVisitHome = DateTime.UtcNow;
        }

        public override void Encode()
        {
            var player = Device.Player;

            player.Home.Tick();

            Writer.WriteInt(0);
            Writer.WriteInt(-1);

            player.LogicClientHome(Writer);
            player.LogicClientAvatar(Writer);

            /*Writer.WriteInt(0);
            Writer.WriteInt(0);

            Writer.WriteLong(1502053689000);
            Writer.WriteLong(1502091670000);
            Writer.WriteLong(1502055489000);

            Writer.WriteInt(0);*/
        }
    }
}