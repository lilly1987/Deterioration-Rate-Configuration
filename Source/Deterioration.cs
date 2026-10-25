using System.Reflection;
using HarmonyLib;
using UnityEngine;
using Verse;

namespace DeteriorationRate
{
    public sealed class Deterioration : Mod
    {
        public Deterioration(ModContentPack content) : base(content)
        {
            GetSettings<DetSettings>();
            new Harmony("rimworld.zezz.deterioration")
                .PatchAll(Assembly.GetExecutingAssembly());
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            var listing = new Listing_Standard();
            listing.Begin(inRect);
            listing.Label("DeteriorationRate".Translate((int)(DetSettings.deteriorationRate * 100f)));
            DetSettings.deteriorationRate = listing.Slider(
                (float)System.Math.Round(DetSettings.deteriorationRate, 2),
                0f,
                10f);
            listing.End();
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "DeteriorationRateCategory".Translate();
        }
    }
}
