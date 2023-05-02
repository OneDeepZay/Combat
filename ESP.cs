using UnityEngine;
using Il2CppCombatMaster.Battle.Gameplay.Player;

namespace Combat
{
    public class ESP
    {
        public static Camera GameCamera => Camera.main;

        public static void Renders()
        {
            RenderPlayers();
        }

        public static void RenderPlayers()
        {
            Camera mainCamera = Camera.main;
            if (mainCamera == null) return;

            float screenHeight = (float)Screen.height;

            foreach (var player in PlayerRoot.AllPlayers)
            {
                if (!player.isActiveAndEnabled)
                {
                    continue;
                }

                Vector3 pivotPos = player.transform.position;

                float footPosY = pivotPos.y - 0.2f;
                float headPosY = pivotPos.y + 1.8f;

                Vector3 w2s_footpos = mainCamera.WorldToScreenPoint(new Vector3(pivotPos.x, footPosY, pivotPos.z));
                Vector3 w2s_headpos = mainCamera.WorldToScreenPoint(new Vector3(pivotPos.x, headPosY, pivotPos.z));

                if (w2s_footpos.z > 0f)
                {
                    DrawBoxESP(w2s_footpos, w2s_headpos, Color.red);
                    DrawDistanceText(w2s_footpos, pivotPos, mainCamera.transform.position);
                }
            }
        }

        public static void DrawBoxESP(Vector3 footpos, Vector3 headpos, Color color)
        {
            float height = headpos.y - footpos.y;
            float width = height / 2f;

            Render.DrawBox(footpos.x - (width / 2), (float)Screen.height - footpos.y - height, width, height, color, 2f);
        }

        public static void DrawDistanceText(Vector3 w2s_footpos, Vector3 playerPos, Vector3 cameraPos)
        {
            float distance = Vector3.Distance(playerPos, cameraPos);
            string distanceText = $"{distance.ToString("F1")}m";

            GUIStyle style = new GUIStyle
            {
                fontSize = 12,
                fontStyle = FontStyle.Normal,
                normal = new GUIStyleState { textColor = Color.white }
            };

            Vector2 textSize = style.CalcSize(new GUIContent(distanceText));
            float textPosX = w2s_footpos.x - (textSize.x / 2);
            float textPosY = (float)Screen.height - w2s_footpos.y;

            GUI.Label(new Rect(textPosX, textPosY, textSize.x, textSize.y), distanceText, style);
        }
    }
}