using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
    public class Projectiles : Data
    {
        public Projectiles(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }

        public string SWF { get; set; }

        public string ExportName { get; set; }

        public bool ScaleTimeline { get; set; }

        public bool UseDirections { get; set; }

        public string ParticleEmitter { get; set; }

        public string Effect { get; set; }

        public int Speed { get; set; }

        public int StartHeight { get; set; }

        public int StartOffset { get; set; }

        public bool IsBallistic { get; set; }

        public string ShadowSWF { get; set; }

        public string ShadowExportName { get; set; }

        public bool RandomHitPosition { get; set; }

        public bool UseRotate { get; set; }

        public bool DirectionFrame { get; set; }

        public bool PlayOnce { get; set; }

        public bool UseTopLayer { get; set; }

        public int Scale { get; set; }

        public string HitSpell { get; set; }

        public int HitSpellLevel { get; set; }

        public bool DontTrackTarget { get; set; }

        public int BallisticHeight { get; set; }

        public int TrajectoryStyle { get; set; }

        public int FixedTravelTime { get; set; }

        public int DamageDelay { get; set; }

        public string DestroyedEffect { get; set; }

        public string BounceEffect { get; set; }

        public int TargetPosRandomRadius { get; set; }

        public int SlowdownDefencePercent { get; set; }
    }
}