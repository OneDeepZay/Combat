using Combat;
using MelonLoader;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Combat.Menus
{
    public class InGameMainMenu
    {
        public static bool Enabled { get; set; } = false;
        public static Rect MenuRect = new Rect(825f, 250f, 460f, 500f);
        private static GUIStyle GUIStyle = new GUIStyle();

        private static bool showCheatScreen = false;

        public static void Render(int windowID)
        {
            GUIStyle coolButtonStyle = new GUIStyle(GUI.skin.button);
            coolButtonStyle.fontStyle = FontStyle.Bold;
            coolButtonStyle.normal.textColor = Color.white;
            coolButtonStyle.hover.textColor = Color.magenta;
            coolButtonStyle.active.textColor = Color.magenta;
            coolButtonStyle.hover.background = Texture2D.whiteTexture;
            coolButtonStyle.active.background = Texture2D.whiteTexture;
            coolButtonStyle.border = new RectOffset(10, 10, 10, 10);

            if (!showCheatScreen)
            {
                RenderMainMenu(coolButtonStyle);
            }
            else if (showCheatScreen)
            {
                RenderCheatScreen();
            }

            GUI.DragWindow(new Rect(0f, 0f, 10000f, 20f));
        }

        public static void RenderMainMenu(GUIStyle coolButtonStyle)
        {

            if (GUI.Button(new Rect(20f, 57f, 130f, 25f), new GUIContent("Cheats"), coolButtonStyle))
            {
                showCheatScreen = true;
            }
        }

        public static void RenderCheatScreen()
        {
            GUIStyle coolButtonStyle = new GUIStyle(GUI.skin.button);
            coolButtonStyle.fontStyle = FontStyle.Bold;
            coolButtonStyle.normal.textColor = Color.white;
            coolButtonStyle.hover.textColor = Color.magenta;
            coolButtonStyle.active.textColor = Color.magenta;
            coolButtonStyle.hover.background = Texture2D.whiteTexture;
            coolButtonStyle.active.background = Texture2D.whiteTexture;
            coolButtonStyle.border = new RectOffset(10, 10, 10, 10);

            if (GUI.Button(new Rect(160f, 155f, 130f, 25f), new GUIContent($"{(CheatToggles.IsOPUnlocked ? "" : "")} Unlock Operators"), coolButtonStyle))
            {
                CheatToggles.IsOPUnlocked = !CheatToggles.IsOPUnlocked;
                Operator.Toggle(CheatToggles.IsOPUnlocked);
            }

            if (GUI.Button(new Rect(160f, 185f, 130f, 25f), new GUIContent($"{(CheatToggles.IsWeaponUnlocked ? "" : "")} Unlock Blueprints"), coolButtonStyle))
            {
                CheatToggles.IsWeaponUnlocked = !CheatToggles.IsWeaponUnlocked;
                Weapons.Toggle(CheatToggles.IsWeaponUnlocked);
            }

            if (GUI.Button(new Rect(160f, 215f, 130f, 25f), new GUIContent($"{(CheatToggles.ESPEnabled ? "" : "")} ESP"), coolButtonStyle))
            {
                CheatToggles.ESPEnabled = !CheatToggles.ESPEnabled;
            }

            if (GUI.Button(new Rect(160f, 245f, 130f, 25f), new GUIContent("Ammo"), coolButtonStyle))
            {
                Ammo.ToggleAmmo();
            }

            if (GUI.Button(new Rect(160f, 275f, 130f, 25f), new GUIContent($"{(CheatToggles.IsEmblemLocked ? "" : "")} Unlock Emblems"), coolButtonStyle))
            {
                CheatToggles.IsEmblemLocked = !CheatToggles.IsEmblemLocked;
                Emblems.Toggle(CheatToggles.IsEmblemLocked);
            }

            if (GUI.Button(new Rect(160f, 305f, 130f, 25f), new GUIContent($"{(CheatToggles.XP ? "" : "")} Match XP"), coolButtonStyle))
            {
                CheatToggles.XP = !CheatToggles.XP;
                XP.ToggleXP(CheatToggles.XP);
            }

            if (GUI.Button(new Rect(160f, 335f, 130f, 25f), new GUIContent("Damage"), coolButtonStyle))
            {
                Damage.ToggleDamage();
            }

            if (GUI.Button(new Rect(160f, 365f, 130f, 25f), new GUIContent("BattlePass"), coolButtonStyle))
            {
                BattlePass.Toggle();
            }

            if (GUI.Button(new Rect(160f, 455f, 130f, 25f), new GUIContent("Back"), coolButtonStyle))
            {
                showCheatScreen = false;
            }
        }
    }
}