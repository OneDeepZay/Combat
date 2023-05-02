using Combat;
using MelonLoader;
using UnityEngine;

public static class BattlePass
{
    public static void Toggle()
    {
        var battlePasses = Resources.FindObjectsOfTypeAll<Il2CppCombatMaster.GDI.Loot.BattlePassInfo>();

        foreach (var battlePass in battlePasses)
        {
            var items = battlePass.LevelsBattlePassItems;
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                item.ExpToGetItem = 0;
                item.IsFree = true;
                items[i] = item;
            }

            var itemss = battlePass.AllBattlePassItems;
            for (int i = 0; i < itemss.Count; i++)
            {
                var itemsss = itemss[i];
                itemsss.ExpToGetItem = 0;
                itemsss.IsFree = true;
                itemss[i] = itemsss;
            }
        }
    }
}