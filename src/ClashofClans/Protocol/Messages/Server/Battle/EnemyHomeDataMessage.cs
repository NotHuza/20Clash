using System;
using ClashofClans.Logic;

namespace ClashofClans.Protocol.Messages.Server.Battle
{
    public class EnemyHomeDataMessage : PiranhaMessage
    {
        public EnemyHomeDataMessage(Device device) : base(device)
        {
            Id = 24107;
            device.CurrentState = Device.State.Battle;
            Device.LastVisitHome = DateTime.UtcNow;
        }

        public Player Enemy { get; set; }

        public override void Encode()
        {
            Enemy.Home.Tick();

            Writer.WriteInt(10);
            Writer.WriteInt(-1);

            Enemy.LogicClientHome(Writer);
            Enemy.LogicClientAvatar(Writer);

            Device.Player.LogicClientAvatar(Writer);

            Writer.WriteInt(3);
            Writer.WriteInt(0);
            Writer.WriteByte(0);
        }
    }
}