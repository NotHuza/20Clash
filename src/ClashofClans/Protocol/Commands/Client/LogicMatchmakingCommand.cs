using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server.Battle;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicMatchmakingCommand : LogicCommand
    {
        public LogicMatchmakingCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public override async void Process()
        {
            // TESTING

            await new EnemyHomeDataMessage(Device)
            {
                Enemy = Device.Player
            }.SendAsync();
        }
    }
}