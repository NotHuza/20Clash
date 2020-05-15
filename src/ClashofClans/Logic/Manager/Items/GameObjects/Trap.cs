using ClashofClans.Files;
using ClashofClans.Files.Logic;
using Newtonsoft.Json.Linq;

namespace ClashofClans.Logic.Manager.Items.GameObjects
{
    public class Trap : GameObject
    {
        public bool AttackMode;
        public int Data;
        public int Id;
        public int Level;

        public Trap(Home.Home home) : base(home)
        {
        }

        public Traps TrapData => Csv.Tables.Get(Csv.Files.Traps).GetDataWithId<Traps>(Data);

        public override void Load(JObject jObject)
        {
            base.Load(jObject);

            Data = jObject["data"].ToObject<int>();
            Level = jObject["lvl"].ToObject<int>();

            if (jObject.ContainsKey("attack_mode"))
                AttackMode = jObject["attack_mode"].ToObject<bool>();
        }

        public override JObject Save()
        {
            var jObject = base.Save();

            jObject.Add("data", Data);
            jObject.Add("id", Id);
            jObject.Add("lvl", Level);

            if (AttackMode)
                jObject.Add("attack_mode", true);

            return jObject;
        }
    }
}