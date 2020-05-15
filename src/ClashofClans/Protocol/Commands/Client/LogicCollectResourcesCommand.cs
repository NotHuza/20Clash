using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
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

        public override async void Process()
        {
            var home = Device.Player.Home;
            var objects = home.GameObjectManager;
            var buildings = objects.GetBuildings();

            var index = buildings.FindIndex(b => b.Id == BuildingId);
            if (index > -1)
            {
                var building = buildings[index];

                home.ComponentManager.CollectResources(building.Data);

                var resourceProductionComponent = building.ResourceProductionComponent;
                var resourceProduces = resourceProductionComponent.ProducesResource;
                var maxStoredResource =
                    home.ComponentManager.MaxStoredResource(resourceProductionComponent.ProducesResource);

                await new GlobalChatLineMessage(Device)
                {
                    Message =
                        $"Storage used: {home.Resources.GetCount(resourceProductionComponent.ResourceData.GetGlobalId())}, Available: {maxStoredResource} - {resourceProduces}"
                }.SendAsync();
            }
            else
            {
                Device.Disconnect($"Building {BuildingId} not found.");
            }
        }
    }
}