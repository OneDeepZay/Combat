using Combat;
using MelonLoader;
using UnityEngine;

public static class Damage
{

    public static void ToggleDamage()
    {
        var WeaponDamage = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.WeaponsGdInfoSection>();
        var WeaponHead = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.WeaponInfo>();

        foreach (var WeaponInfo in WeaponDamage)
        {
            WeaponInfo.DamageGlobalMaximum = 1000000;
        }

        foreach (var Weapon in WeaponHead)
        {
            Weapon.DamageHeadMultiplier = 1000000;
        }
    }
}
