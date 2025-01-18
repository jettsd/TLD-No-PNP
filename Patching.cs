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
            foreach (mainscript.fluid fluid2 in __instance.player.piss.Tank.F.fluids)
            {
                if (fluid2.type == mainscript.fluidenum.water)
                {
                    fluid2.amount = 0;
                }
            }

        }

        [HarmonyPostfix]
        [HarmonyPatch("Update")]
        public static void PostfixUpdate(global::survivalscript __instance)
        {
            __instance.shit = 0;
        }
        
    }
}