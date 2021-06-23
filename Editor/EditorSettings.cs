using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(UpgradeTreeData))]
public class EditorSettings : Editor
{
    //TypeSetting typeSetting
    UpgradeTreeData upgradeTreeData;

    private void OnEnable()
    {
        upgradeTreeData = (UpgradeTreeData) target;
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();

        if (GUI.changed)
        {
            EditorUtility.SetDirty(upgradeTreeData);

            if (GUI.changed)
            {
                EditorUtility.SetDirty(upgradeTreeData);
            }
        }

        upgradeTreeData.typeSetting = (UpgradeTreeData.TypeSetting)EditorGUILayout.EnumPopup("type", upgradeTreeData.typeSetting);

        if (upgradeTreeData.typeSetting == UpgradeTreeData.TypeSetting.Processor)
        {
            upgradeTreeData.NameUpgrade = EditorGUILayout.TextField("Name", upgradeTreeData.NameUpgrade);
            upgradeTreeData.Cost = EditorGUILayout.IntField("Cost", (int)upgradeTreeData.Cost);
            upgradeTreeData.Level = EditorGUILayout.IntField("Level", upgradeTreeData.Level);
            upgradeTreeData.TextLevel = EditorGUILayout.TextField("Text level", upgradeTreeData.TextLevel);
            upgradeTreeData.CoreProcessor = EditorGUILayout.IntField("Cores", upgradeTreeData.CoreProcessor);
            upgradeTreeData.PowerProcessor = EditorGUILayout.IntField("Мощность в баллах", upgradeTreeData.PowerProcessor);
        }

        if (upgradeTreeData.typeSetting == UpgradeTreeData.TypeSetting.upgrade)
        {
            upgradeTreeData.NameUpgrade = EditorGUILayout.TextField("Name", upgradeTreeData.NameUpgrade);
            upgradeTreeData.Cost = EditorGUILayout.IntField("Cost", (int)upgradeTreeData.Cost);
            upgradeTreeData.Level = EditorGUILayout.IntField("Level", upgradeTreeData.Level);
            upgradeTreeData.TextLevel = EditorGUILayout.TextField("Text level", upgradeTreeData.TextLevel);
            upgradeTreeData.LevelRequired = EditorGUILayout.IntField("Требуемый уровень улучшения", upgradeTreeData.LevelRequired);
            upgradeTreeData.RealtorCompany = EditorGUILayout.IntField("Может иметь", upgradeTreeData.RealtorCompany);
            upgradeTreeData.OfficeStafs = EditorGUILayout.IntField("Сотрудников", upgradeTreeData.OfficeStafs);
            upgradeTreeData.RatingOS = EditorGUILayout.IntField("Рейтинг ОС", upgradeTreeData.RatingOS);
        }

        if (upgradeTreeData.typeSetting == UpgradeTreeData.TypeSetting.Videocard)
        {
            upgradeTreeData.NameUpgrade = EditorGUILayout.TextField("Name", upgradeTreeData.NameUpgrade);
            upgradeTreeData.Cost = EditorGUILayout.IntField("Cost", (int)upgradeTreeData.Cost);
            upgradeTreeData.Level = EditorGUILayout.IntField("Level", upgradeTreeData.Level);
            upgradeTreeData.TextLevel = EditorGUILayout.TextField("Text level", upgradeTreeData.TextLevel);
            upgradeTreeData.VRAM = EditorGUILayout.IntField("VRAM", upgradeTreeData.VRAM);
            upgradeTreeData.TypeVRAM = EditorGUILayout.IntField("Type VRAM", upgradeTreeData.TypeVRAM);
            upgradeTreeData.PowerVideocard = EditorGUILayout.IntField("Мощность в баллах", upgradeTreeData.PowerVideocard);
            upgradeTreeData.typeVideocard = (UpgradeTreeData.TypeVideocard)EditorGUILayout.EnumPopup("Type videocard", upgradeTreeData.typeVideocard);
        }

        if (upgradeTreeData.typeSetting == UpgradeTreeData.TypeSetting.Marketing)
        {
            upgradeTreeData.NameUpgrade = EditorGUILayout.TextField("Name", upgradeTreeData.NameUpgrade);
            upgradeTreeData.Cost = EditorGUILayout.IntField("Cost", (int)upgradeTreeData.Cost);
            upgradeTreeData.Level = EditorGUILayout.IntField("Level", upgradeTreeData.Level);
            upgradeTreeData.TextLevel = EditorGUILayout.TextField("Text level", upgradeTreeData.TextLevel);
            upgradeTreeData.DayMarketing = EditorGUILayout.IntField("сколько длится реклама", upgradeTreeData.DayMarketing);
            upgradeTreeData.MinPlusFun = EditorGUILayout.IntField("Минимум фанатов прибавится", upgradeTreeData.MinPlusFun);
            upgradeTreeData.MaxPlusFun = EditorGUILayout.IntField("Максимум фанатов прибаввится", upgradeTreeData.MaxPlusFun);
        }

        if (upgradeTreeData.typeSetting == UpgradeTreeData.TypeSetting.Quest)
        {
            upgradeTreeData.TextConditions = EditorGUILayout.TextField("Условия", upgradeTreeData.TextConditions);
            upgradeTreeData.RewardQuest = EditorGUILayout.DoubleField("Награда", upgradeTreeData.RewardQuest);
            upgradeTreeData.Conditions = EditorGUILayout.DoubleField("Сколько надо", upgradeTreeData.Conditions);
        }

        EditorGUILayout.EndVertical();
    }
}
