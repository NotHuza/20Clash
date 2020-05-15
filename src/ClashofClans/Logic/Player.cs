using System;
using ClashofClans.Database;
using ClashofClans.Utilities.Netty;
using ClashofClans.Utilities.Utils;
using DotNetty.Buffers;
using Newtonsoft.Json;

namespace ClashofClans.Logic
{
    public class Player
    {
        public Player(long id)
        {
            Home = new Home.Home(id, GameUtils.GenerateToken);
        }

        public Player()
        {
            // Player.
        }

        public Home.Home Home { get; set; }

        [JsonIgnore] public Device Device { get; set; }

        public void RankingEntry(IByteBuffer packet)
        {
            // TODO
        }

        public void LogicClientHome(IByteBuffer packet)
        {
            packet.WriteInt(TimeUtils.CurrentUnixTimestamp);

            // Home Id
            packet.WriteLong(Home.Id);

            packet.WriteInt(0); // Shield
            packet.WriteInt(0); // Protection

            packet.WriteInt(0);

            packet.WriteCompressedString(Home.GameObjectManager.Save());

            packet.WriteCompressedString("{\"event\":[]}");
            packet.WriteCompressedString("{\"Village2\":{\"TownHallMaxLevel\":9}}");
        }

        public void LogicClientAvatar(IByteBuffer packet)
        {
            // Account Id
            packet.WriteLong(Home.Id);

            // Home Id
            packet.WriteLong(Home.Id);

            packet.WriteBoolean(true); // HasAlliance

            packet.WriteLong(1);
            packet.WriteScString("Test");
            packet.WriteInt(1); // Badge
            packet.WriteInt(1); // Members/Online?
            packet.WriteInt(0); // Members/Online?

            packet.WriteBoolean(false);
            packet.WriteLong(1);

            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(1000);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(1000);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(10);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);

            packet.WriteScString(Home.Name);
            packet.WriteScString(null); // Facebook

            packet.WriteInt(Home.ExpLevel); // Level
            packet.WriteInt(Home.ExpPoints); // Exp

            packet.WriteInt(Home.Diamonds);
            packet.WriteInt(Home.Diamonds);

            packet.WriteInt(1200);
            packet.WriteInt(60);

            packet.WriteInt(0); // Trophies
            packet.WriteInt(0); // Builderbase Trophies

            packet.WriteInt(0); // Wins 
            packet.WriteInt(0); // Losses

            packet.WriteInt(0); // Defend Wins
            packet.WriteInt(0); // Defend Losses

            packet.WriteInt(0); // Clan Castle Gold
            packet.WriteInt(0); // Clan Castle Elixir
            packet.WriteInt(0); // Clan Castle Dark Elixir

            packet.WriteInt(0);
            packet.WriteByte(1);

            packet.WriteInt(0);
            packet.WriteInt(-1);

            packet.WriteInt(0);
            packet.WriteInt(0);

            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);

            packet.WriteByte(0);

            // Resource Cap
            packet.WriteInt(8);
            packet.WriteInt(3000001);
            packet.WriteInt(8500000);
            packet.WriteInt(3000002);
            packet.WriteInt(8500000);
            packet.WriteInt(3000003);
            packet.WriteInt(60000);
            packet.WriteInt(3000004);
            packet.WriteInt(2000000);
            packet.WriteInt(3000005);
            packet.WriteInt(2000000);
            packet.WriteInt(3000006);
            packet.WriteInt(10000);
            packet.WriteInt(3000007);
            packet.WriteInt(900000);
            packet.WriteInt(3000008);
            packet.WriteInt(900000);

            Home.Resources.Encode(packet);

            packet.WriteInt(0); // Home Troops
            packet.WriteInt(0); // Spells
            packet.WriteInt(0); // Home Troop Levels
            packet.WriteInt(0); // Spell Levels

            packet.WriteInt(4); // Hero Levels
            packet.WriteInt(28000000);
            packet.WriteInt(44);
            packet.WriteInt(28000001);
            packet.WriteInt(44);
            packet.WriteInt(28000002);
            packet.WriteInt(19);
            packet.WriteInt(28000003);
            packet.WriteInt(29);

            packet.WriteInt(4); // Hero Healths
            packet.WriteInt(28000000);
            packet.WriteInt(0);
            packet.WriteInt(28000001);
            packet.WriteInt(0);
            packet.WriteInt(28000002);
            packet.WriteInt(0);
            packet.WriteInt(28000003);
            packet.WriteInt(0);

            packet.WriteInt(4); // Hero States
            packet.WriteInt(28000000);
            packet.WriteInt(3);
            packet.WriteInt(28000001);
            packet.WriteInt(3);
            packet.WriteInt(28000002);
            packet.WriteInt(3);
            packet.WriteInt(28000003);
            packet.WriteInt(2);

            // Clan Units
            packet.WriteInt(0);

            packet.WriteInt(1);
            packet.WriteInt(28000003);

            packet.WriteInt(3);
            packet.WriteInt(0);

            // Tutorials | 10 = Set Name - 35 All tutorials 
            var mission = Home.NameSet == 0 ? 10 : 35;
            packet.WriteInt(mission);
            for (var i = 0; i < mission; i++)
                packet.WriteInt(21000000 + i);

            packet.WriteInt(0); // Achievements - 23000000
            packet.WriteInt(0); // Completed Achievements Slots

            packet.WriteInt(94); // NPC
            for (var i = 17000000; i < 17000094; i++)
            {
                packet.WriteInt(i);
                packet.WriteInt(3);
            }

            packet.WriteInt(0); // NPC Gold Gain
            packet.WriteInt(0); // NPC Elixir Gain
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);

            packet.WriteInt(0); // 97

            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(16777216);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);
            packet.WriteInt(0);

            packet.WriteByte(0);
        }

        /*public async void AddEntry(AvatarStreamEntry entry)
        {
            lock (Home.Stream)
            {
                while (Home.Stream.Count >= 40)
                    Home.Stream.RemoveAt(0);

                var max = Home.Stream.Count == 0 ? 1 : Home.Stream.Max(x => x.Id);
                entry.Id = max == int.MaxValue ? 1 : max + 1; // If we ever reach that value... but who knows...

                Home.Stream.Add(entry);
            }

            await new AvatarStreamEntryMessage(Device)
            {
                Entry = entry
            }.SendAsync();
        }*/

        /// <summary>
        ///     Validates this session
        /// </summary>
        public void ValidateSession()
        {
            var session = Device.Session;
            session.Duration = (int) DateTime.UtcNow.Subtract(session.SessionStart).TotalSeconds;

            Home.TotalPlayTimeSeconds += session.Duration;

            while (Home.Sessions.Count >= 50) Home.Sessions.RemoveAt(0);

            Home.Sessions.Add(session);
        }

        public async void Save()
        {
            Home.LastSaveTime = DateTime.UtcNow;

/*#if DEBUG
            var st = new Stopwatch();
            st.Start();

            Resources.ObjectCache.CachePlayer(this);
            await PlayerDb.SaveAsync(this);

            st.Stop();
            Logger.Log($"Player {Home.Id} saved in {st.ElapsedMilliseconds}ms.", GetType(), ErrorLevel.Debug);
#else*/
            Resources.ObjectCache.CachePlayer(this);
            await PlayerDb.SaveAsync(this);
//#endif
        }
    }
}