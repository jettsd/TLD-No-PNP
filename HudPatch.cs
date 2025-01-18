using HarmonyLib;

namespace NoPissNShit
{
    
        [HarmonyPatch(typeof(mainscript))]
        public static class HudPatch
        {
            [HarmonyPostfix]
            [HarmonyPatch("Update")]
            public static void Postfix(global::mainscript __instance)
            {
                __instance.menu.SShit.gameObject.SetActive(false);
                __instance.menu.SPiss.gameObject.SetActive(false);
            }
        }
    
}