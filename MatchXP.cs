using Combat;
using MelonLoader;
using System.Collections.Generic;
using UnityEngine;

public static class XP
{
    private static bool _isEnable;

    public static void ToggleXP(bool status)
    {
        _isEnable = status;

        if (_isEnable)
        {
            var MatchXP = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.MatchInfo>();
            var WeaponXP = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.BattleInfo>();
            var LevelsXP = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.LevelsInfo>();

            foreach (var level in LevelsXP)
            {
                for (int i = 0; i < level._xpOfLevel.Count; i++)
                {
                    level._xpOfLevel[i] = 0;
                }
            }

            foreach (var xp in MatchXP)
            {
                xp.FirstPlaceExpBonus = 65000;
                xp.HighlightExpMultiplier = 65000;
                xp.SecondPlaceExpBonus = 65000;
                xp.ThirdPlaceExpBonus = 65000;
                xp.VictoryExpBonus = 65000;
            }

            foreach (var weapon in WeaponXP)
            {
                weapon.ArmorDestroy = 65000;
                weapon.Assist = 65000;
                weapon.BaseKill = 65000;
                weapon.BombPlanted = 65000;
                weapon.ClearKill = 65000;
                weapon.DoubleKill = 65000;
                weapon.Downed = 65000;
                weapon.FirstBlood = 65000;
                weapon.Grenade = 65000;
                weapon.GunPromotion = 65000;
                weapon.Harakiri = 65000;
                weapon.Headshot = 65000;
                weapon.HipFire = 65000;
                weapon.InAirKill = 65000;
                weapon.InSlideKill = 65000;
                weapon.KillActor = 65000;
                weapon.KingSlayer = 65000;
                weapon.Knife = 65000;
                weapon.LastBullet = 65000;
                weapon.LongShot = 65000;
                weapon.MajorStopStreak = 65000;
                weapon.MultiKill = 65000;
                weapon.NoAttach = 65000;
                weapon.NoScope = 65000;
                weapon.NoScope360 = 65000;
                weapon.OneShotMultiKill = 65000;
                weapon.OneShotOneKill = 65000;
                weapon.OnVergeOfDeath = 65000;
                weapon.OnZipLineKill = 65000;
                weapon.Revenge = 65000;
                weapon.StopStreak = 65000;
                weapon.TeamWiped = 65000;
                weapon.ThroughWall = 65000;
                weapon.TripleKill = 65000;
                weapon.UseMinigun = 65000;
                weapon.UseNuke = 65000;
                weapon.WeaponBash = 65000;
            }
        }
    }
}
