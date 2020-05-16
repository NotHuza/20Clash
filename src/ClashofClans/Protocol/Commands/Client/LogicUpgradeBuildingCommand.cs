using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicUpgradeBuildingCommand : LogicCommand
    {
        public LogicUpgradeBuildingCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int BuildingId { get; set; }
        public bool UseAltResource { get; set; }

        public override void Decode()
        {
            BuildingId = Reader.ReadInt();
            UseAltResource = Reader.ReadBoolean();

            Reader.ReadByte();
            Reader.ReadByte();
            Reader.ReadByte();

            base.Decode();
        }

        public override void Process()
        {
            var home = Device.Player.Home;
            var objects = home.GameObjectManager;

            if (BuildingId - 504000000 < 0)
            {
                /*if (objects.IsWorkerAvailable())
                {*/
                var buildings = objects.GetBuildings();

                var index = buildings.FindIndex(b => b.Id == BuildingId);
                if (index > -1)
                {
                    var building = buildings[index];

                    // For Builderbase Tutorial
                    /*if (home.State == 1 && building.Data == 1000034 && building.Level == 0)
                        foreach (var b in buildings)
                            if (b.RequiredTownhallLevel(false) <= 2)
                            {
                                b.StartUnlocking();
                                b.FinishUnlocking();
                            }*/

                    var paid = home.UseResourceByName(
                        UseAltResource
                            ? building.BuildingData.AltBuildResource[building.GetUpgradeLevel()]
                            : building.BuildingData.BuildResource,
                        building.BuildingData.BuildCost[building.GetUpgradeLevel() + 1]);

                    if (paid)
                        building.StartUpgrade();
                    else
                        Device.Disconnect("Payment failed.");
                }
                else
                {
                    Device.Disconnect($"Building {BuildingId} not found.");
                }

                /*}
                else
                {
                    Device.Disconnect("No worker available!");
                }*/
            }
            else if (BuildingId - 507000000 < 0)
            {
                // Decorations
                Device.Disconnect("Decorations are not supported for this command yet.");
            }
            else if (BuildingId - 508000000 < 0)
            {
                // Traps
                Device.Disconnect("Traps are not supported for this command yet.");
            }
            else
            {
                var villageObjects = objects.VillageObjects;

                var index = villageObjects.FindIndex(vo => vo.Id == BuildingId);
                if (index > -1)
                {
                    var villageObject = villageObjects[index];

                    var villageObjectData = villageObject.VillageObjectsData;

                    var paid = home.UseResourceByName(villageObjectData.BuildResource, villageObjectData.BuildCost);
                    if (paid)
                        villageObject.StartUpgrade();
                    else
                        Device.Disconnect("Payment failed.");
                }
                else
                {
                    Device.Disconnect($"VillageObject {BuildingId} not found.");
                }
            }
        }
    }
}