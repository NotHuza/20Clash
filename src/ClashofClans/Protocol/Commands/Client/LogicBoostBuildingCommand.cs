using System.Collections.Generic;
using System.Linq;
using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicBoostBuildingCommand : LogicCommand
    {
        public LogicBoostBuildingCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public List<int> Buildings { get; set; }

        public override void Decode()
        {
            var count = Reader.ReadInt();
            Buildings = new List<int>(count);

            for (var i = 0; i < count; i++)
            {
                Buildings.Add(Reader.ReadInt());
            }

            base.Decode();
        }

        public override void Process()
        {
            var home = Device.Player.Home;
            var buildings = home.GameObjectManager.GetBuildings();

            foreach (var building in from id in Buildings select buildings.FindIndex(x => x.Id == id) into index where index > -1 select buildings[index])
            {
                building.StartBoost();
            }
        }
    }
}