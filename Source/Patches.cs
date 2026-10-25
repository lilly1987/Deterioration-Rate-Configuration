using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace DeteriorationRate
{
    [HarmonyPatch(
        typeof(SteadyEnvironmentEffects),
        nameof(SteadyEnvironmentEffects.FinalDeteriorationRate),
        new[]
        {
            typeof(Thing),
            typeof(bool),
            typeof(bool),
            typeof(TerrainDef),
            typeof(List<string>)
        })]
    public static class Patches
    {
        private static void Postfix(ref float __result)
        {
            __result *= DetSettings.deteriorationRate;
        }
    }
}
