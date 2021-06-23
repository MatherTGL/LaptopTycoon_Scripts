using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Upgrade Tree", menuName = "Create Upgrade Tree Button")]
public class UpgradeTreeData : ScriptableObject
{
    public double Cost; //Цена за улучшение

    public string NameUpgrade; //Название улучшения
    
    public int Level; //Уровень улучшения 

    public string TextLevel;

    public int LevelRequired; //Требуемсый уровень для улучшения

    public int RealtorCompany; //Сколько может иметь игрок на старте компаний в собственности

    public int RatingUpgrade; //Сколько добавит рейтинга улучшение

    public int OfficeStafs; //Сколько может быть сотрудников в офисе

    public int RatingOS; //Рейтинг операционки игрока


    //Videocard
    public int VRAM; //8 GB
    public int TypeVRAM; //GDDR 6
    public int PowerVideocard; //Производительность видеокарты

    //Processor
    public int CoreProcessor; //6 CORES
    public int PowerProcessor; //Производительность процессора

    //Marketing
    public int DayMarketing; //сколько дней длится реклама
    public int MinPlusFun; //Минимум сколько может дать фанатов реклама
    public int MaxPlusFun; //Максимум сколько может дать фанатов реклама

    //Quest
    public string TextConditions;   
    public double RewardQuest;
    public double Conditions;

    public TypeSetting typeSetting;
    public TypeVideocard typeVideocard;



    public enum TypeSetting
    {
        upgrade,
        Videocard,
        Processor,
        Marketing,
        Quest
    }

    public enum TypeVideocard
    {
        GTX,
        RTX
    }   
}
