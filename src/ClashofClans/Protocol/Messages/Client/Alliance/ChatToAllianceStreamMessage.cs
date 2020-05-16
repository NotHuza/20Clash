using System;
using System.Linq;
using ClashofClans.Database;
using ClashofClans.Files;
using ClashofClans.Logic;
using ClashofClans.Protocol.Commands.Server;
using ClashofClans.Protocol.Messages.Server;
using ClashofClans.Utilities;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Alliance
{
    public class ChatToAllianceStreamMessage : PiranhaMessage
    {
        public ChatToAllianceStreamMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public string Message { get; set; }

        public override void Decode()
        {
            Message = Reader.ReadScString();
        }

        public override async void Process()
        {
            if (Message.StartsWith('/'))
            {
                var cmd = Message.Split(' ');
                var cmdType = cmd[0];
                var cmdValue = 0;

                if (cmd.Length > 1)
                    if (Message.Split(' ')[1].Any(char.IsDigit))
                        int.TryParse(Message.Split(' ')[1], out cmdValue);

                switch (cmdType)
                {
                    case "/skip":
                    {
                        Device.Player.Home.FastForward(cmdValue);

                        await new OwnHomeDataMessage(Device).SendAsync();

                        break;
                    }

                    case "/visit":
                    {
                        await new VisitedHomeDataMessage(Device)
                        {
                            Player = Device.Player
                        }.SendAsync();

                        break;
                    }

                    case "/co":
                    {
                        var manager = Device.Player.Home.GameObjectManager;
                        manager.Obstacles.Clear();
                        manager.Obstacles2.Clear();

                        await new OwnHomeDataMessage(Device).SendAsync();

                        break;
                    }

                    case "/reset":
                    {
                        Device.Player.Home.Reset();

                        await new OwnHomeDataMessage(Device).SendAsync();

                        break;
                    }

                    case "/max":
                    {
                        Device.Player.Home.ExpLevel = 300;
                        Device.Player.Home.ExpPoints = 0;
                        Device.Player.Home.GameObjectManager.LoadJson(Levels.MaxHome);

                        await new OwnHomeDataMessage(Device).SendAsync();

                        break;
                    }

                    case "/gems":
                    {
                        Device.Player.Home.Diamonds += 14000;

                        await new AvailableServerCommandMessage(Device)
                        {
                            Command = new LogicDiamondsAddedCommand(Device)
                            {
                                Diamonds = 14000
                            }.Handle()
                        }.SendAsync();

                        break;
                    }

                    case "/low":
                    {
                        var home = Device.Player.Home;

                        home.Resources.InitializeDefault();
                        home.Diamonds = 100;

                        await new OwnHomeDataMessage(Device).SendAsync();

                        break;
                    }

                    case "/high":
                    {
                        var home = Device.Player.Home;

                        home.Resources.Initialize();

                        await new OwnHomeDataMessage(Device).SendAsync();

                        break;
                    }

                    case "/status":
                    {
                        await new LoginFailedMessage(Device)
                        {
                            Reason = 
                                $"OnlinePlayers: {Resources.Players.Count}\nCached Players: {Resources.ObjectCache.CachedPlayers()}\nTotal Players: {await PlayerDb.CountAsync()}\nUptime: {DateTime.UtcNow.Subtract(Resources.StartTime).ToReadableString()}"
                        }.SendAsync();

                        break;
                    }

                    case "/help":
                    {
                        await new LoginFailedMessage(Device)
                        {
                            Reason =
                                "/status - See the current server status\n/low - Get minimum of resources\n/high - Get max resources\n/gems - Adds 14k gems\n/reset - Reset your village\n/visit - Visit your own village\n/max - Get a max village\n/co - Clear all obstacles\n/skip [seconds] - Skip time"
                        }.SendAsync();

                        break;
                    }
                }
            }
        }
    }
}