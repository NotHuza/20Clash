using System.Collections.Generic;
using System.Numerics;
using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicBuyWallCommand : LogicCommand
    {
        public LogicBuyWallCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int BuildingData { get; set; }
        public List<Vector2> Positions { get; set; }

        public override void Decode()
        {
            var count = Reader.ReadInt();

            Positions = new List<Vector2>(count);

            for (var i = 0; i < count; i++)
            {
                var x = Reader.ReadInt();
                var y = Reader.ReadInt();

                Positions.Add(new Vector2(x, y));
            }

            BuildingData = Reader.ReadInt();

            base.Decode();
        }

        public override void Process()
        {
            var home = Device.Player.Home;
            //var buildings = home.GameObjectManager.GetBuildings();

            /*if (home.GameObjectManager.IsWorkerAvailable())
            {
                var data = Csv.Tables.Get(Csv.Files.Buildings).GetDataWithId<Buildings>(BuildingData);
                var cost = data.BuildCost[0];

                if (home.UseResourceByName(data.BuildResource, cost))
                {
                    var wallId = buildings.Count;
                    var count = 0;

                    foreach (var pos in Positions)
                    {
                        var building = new Building
                        {
                            X = (int) pos.X,
                            Y = (int) pos.Y,
                            Data = BuildingData,
                            Id = 500000000 + buildings.Count,
                            Wi = wallId
                        };

                        if (count == 0)
                            building.Wp = 1;

                        building.Wx = count++;

                        buildings.Add(building);
                    }
                }
                else
                {
                    Device.Disconnect("Failed to buy wall.");
                }
            }
            else
            {
                Device.Disconnect("No worker available!");
            }*/

            Device.Disconnect("Failed to buy wall.");
        }
    }
}