using Combat;
using MelonLoader;
using UnityEngine;

public static class Weapons
{
    private static bool _isEnable;

    public static void Toggle(bool status)
    {
        _isEnable = status;

        if (_isEnable)
        {
            var weaponInfoObjects = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.WeaponBlueprintInfo>();
            var weaponLockedInfoObjects = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.WeaponInfo>();

            foreach (var weaponInfo in weaponInfoObjects)
            {
                weaponInfo._isPremium = !_isEnable;
            }

            foreach (var weaponLockedInfo in weaponLockedInfoObjects)
            {
                weaponLockedInfo.LevelLock = 1;
            }
        }
    }
}