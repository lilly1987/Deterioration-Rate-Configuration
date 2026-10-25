using Verse;

namespace DeteriorationRate
{
    public sealed class DetSettings : ModSettings
    {
        public static float deteriorationRate = 1f;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref deteriorationRate, "DeteriorationRate", 1f);
        }
    }
}
