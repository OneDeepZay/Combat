using Combat;
using MelonLoader;
using UnityEngine;

public static class Operator
{
    private static bool _isEnable;

    public static void Toggle(bool status)
    {
        _isEnable = status;

        if (_isEnable)
        {

            var operatorInfoObjects = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.OperatorInfo>();

            foreach (var operatorInfo in operatorInfoObjects)
            {
                operatorInfo.IsPremium = !_isEnable;
                operatorInfo.LevelLock = 1;
            }
        }
    }
}