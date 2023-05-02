using MelonLoader;
using UnityEngine;
using Combat.Menus;
using System.Collections.Generic;

namespace Combat
{
    public class Main : MelonMod
    {
        public static Camera GameCamera => Camera.main;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg($"Scene {sceneName} with build index {buildIndex} has been loaded!");

            InGameMainMenu.Enabled = false;
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                InGameMainMenu.Enabled = !InGameMainMenu.Enabled;
            }
        }

        public override void OnGUI()
        {
            GUI.backgroundColor = Color.black;

            if (InGameMainMenu.Enabled)
            {
                InGameMainMenu.MenuRect = GUI.Window(1, InGameMainMenu.MenuRect, (GUI.WindowFunction)InGameMainMenu.Render, "Combat Master Menu By OneDeepZay & Livid");
            }

            if (CheatToggles.ESPEnabled)
            {
                ESP.Renders();
            }
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            InGameMainMenu.Enabled = false;
            CheatToggles.ESPEnabled = false;
            CheatToggles.IsOPUnlocked = false;
            CheatToggles.IsWeaponUnlocked = false;
            CheatToggles.IsWeaponLocked = false;
            CheatToggles.IsEmblemLocked = false;
        }
    }
}