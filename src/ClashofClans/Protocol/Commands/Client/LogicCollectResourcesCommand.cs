using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicCollectResourcesCommand : LogicCommand
    {
        public LogicCollectResourcesCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int BuildingId { get; set; }

        public override void Decode()
        {
            BuildingId = Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            var home = Device.Player.Home;
            var objects = home.GameObjectManager;
            var buildings = objects.GetBuildings();

            var index = buildings.FindIndex(b => b.Id == BuildingId);
            if (index > -1)
            {
                var building = buildings[index];

                Logger.Log($"Collected: {building.ResourceProductionComponent.AvailableToCollect}", GetType(), Logger.ErrorLevel.Debug);

                home.ComponentManager.CollectResources(building.Data);

                var resourceProductionComponent = building.ResourceProductionComponent;
                var resourceProduces = resourceProductionComponent.ProducesResource;
                var maxStoredResource =
                    home.ComponentManager.MaxStoredResource(resourceProduces);

                //Logger.Log($"Storage used: {home.Resources.GetCount(resourceProductionComponent.ResourceData.GetGlobalId())}, Available: {maxStoredResource} - {resourceProduces}", GetType(), Logger.ErrorLevel.Debug);
            }
            else
            {
                Device.Disconnect($"Building {BuildingId} not found.");
            }
        }
    }
}