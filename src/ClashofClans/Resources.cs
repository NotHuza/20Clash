using System;
using System.Threading.Tasks;
using ClashofClans.Core;
using ClashofClans.Core.Network;
using ClashofClans.Database;
using ClashofClans.Database.Cache;
using ClashofClans.Files;
using ClashofClans.Utilities.Utils;

namespace ClashofClans
{
    public static class Resources
    {
        public static Logger Logger { get; set; }
        public static Configuration Configuration { get; set; }

        public static PlayerDb PlayerDb { get; set; }

        //public static AllianceDb AllianceDb { get; set; }
        public static ObjectCache ObjectCache { get; set; }
        //public static Leaderboard Leaderboard { get; set; }

        public static NettyService Netty { get; set; }

        public static Fingerprint Fingerprint { get; set; }
        public static Csv Csv { get; set; }
        public static Levels Levels { get; set; }

        public static Players Players { get; set; }
        //public static Alliances Alliances { get; set; }

        public static DateTime StartTime { get; set; }

        public static async void Initialize()
        {
            Logger = new Logger();
            Logger.Log(
                $"Starting [{DateTime.Now.ToLongTimeString()} - {ServerUtils.GetOsName()}]...",
                null);

            Configuration = new Configuration();
            Configuration.Initialize();

            Fingerprint = new Fingerprint();
            Levels = new Levels();
            Csv = new Csv();

            PlayerDb = new PlayerDb();
            //AllianceDb = new AllianceDb();

            Logger.Log(
                $"Successfully loaded MySql with {await PlayerDb.CountAsync()} player(s)",
                null);

            ObjectCache = new ObjectCache();

            Players = new Players();
            //Alliances = new Alliances();

            //Leaderboard = new Leaderboard();

            StartTime = DateTime.UtcNow;

            Netty = new NettyService();

            await Task.Run(Netty.RunServerAsync);
        }
    }
}