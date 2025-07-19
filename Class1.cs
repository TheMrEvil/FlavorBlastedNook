using System;
using MelonLoader;
using HarmonyLib;
using UnityEngine;

namespace FlavorBlastedNook
{
    public class Class1 : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Flavor Blasted Nook mod loaded!");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            // Increase the nook limit when the scene loads
            if (NookDB.DB != null)
            {
                NookDB.DB.NookLimit = 150;
            }
        }
    }
}
