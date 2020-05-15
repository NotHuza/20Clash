using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicSpeedUpConstructionCommand : LogicCommand
    {
        public LogicSpeedUpConstructionCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int BuildingId { get; set; }

        public override void Decode()
        {
            BuildingId = Reader.ReadInt();
            Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            var home = Device.Player.Home;
            var objects = home.GameObjectManager;

            if (BuildingId - 504000000 < 0)
            {
                var buildings = objects.GetBuildings();

                var index = buildings.FindIndex(b => b.Id == BuildingId);
                if (index > -1)
                {
                    var building = buildings[index];
                    building.SpeedUpConstruction();
                }
                else
                {
                    Device.Disconnect($"Building {BuildingId} not found.");
                }
            }
            else if (BuildingId - 506000000 < 0)
            {
                Device.Disconnect("Decorations are not supported for this command.");
            }
            else
            {
                var villageObjects = objects.VillageObjects;

                var index = villageObjects.FindIndex(vo => vo.Id == BuildingId);
                if (index > -1)
                {
                    var villageObject = villageObjects[index];
                    villageObject.SpeedUpConstruction();
                }
                else
                {
                    Device.Disconnect($"VillageObject {BuildingId} not found.");
                }
            }
        }
    }
}