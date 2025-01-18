using BepInEx;
using HarmonyLib;

namespace NoPissNShit
{
    [BepInPlugin(ModID, ModName, ModVersion)]
    public class No_PP : BaseUnityPlugin

    {
        public const string ModName = "no piss and shit";
        public const string AuthorName = "Jettsd & Blue";
        public const string ModID = "JettsdNoPP";
        public const string ModVersion = "1.0.0";

        public void Awake()
        {
            Harmony harmony = new Harmony(ModID);
            harmony.PatchAll();
        }

    }
}