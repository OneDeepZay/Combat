using Combat;
using MelonLoader;
using UnityEngine;

public static class Emblems
{
    private static bool _isEnable;

    public static void Toggle(bool status)
    {
        _isEnable = status;

        if (_isEnable)
        {

            var EmblemsLocked = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.EmblemInfo>();

            foreach (var emblem in EmblemsLocked)
            {
                emblem.IsPremium = !_isEnable;
                emblem.LevelLock = 1;
            }
        }
    }
}