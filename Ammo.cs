using Combat;
using MelonLoader;
using UnityEngine;

public static class Ammo
{

    public static void ToggleAmmo()
    {
        var weaponAmmoInfoObjects = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.WeaponInfo>();

        foreach (var WeaponInfo in weaponAmmoInfoObjects)
        {
            WeaponInfo.AmmoAmount = 6666;
        }
    }
}
