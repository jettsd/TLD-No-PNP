using HarmonyLib;

namespace NoPissNShit
{
    [HarmonyPatch(typeof(global::survivalscript))]
    public static class Patching
    {
        [HarmonyPostfix]
        [HarmonyPatch("ConvWaterToPiss")]
        public static void Postfix(global::survivalscript __instance)
        {
            __instance.player.piss.Tank.F.fluids.Clear();

        }

        [HarmonyPostfix]
        [HarmonyPatch("Update")]
        public static void PostfixUpdate(global::survivalscript __instance)
        {
            __instance.shit = 0;
        }
        
    }
}