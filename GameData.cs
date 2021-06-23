using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{  
    [SerializeField] private MainGameMechanics _mainGameMechanicsAccess;
    [SerializeField] private Crisis _crisis;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private Laboratory _laboratory;
    [SerializeField] private BuyLabUpgrade _buyLabUpgrade;

    [Header("День")]
    public byte Day;
    [HideInInspector]
    public Text TextDay;
    [Header("Месяц")]
    public byte Month;
    [HideInInspector]
    public Text TextMonth;
    [Header("Год")]
    public uint Year;
    [HideInInspector]
    public Text TextYear;

    //Month
    [Header("Месяца")] //Всё кол-во дней привышает +1 от оригинального, но в игре будет видно лишь настоящее кол-во дней
    
    private byte _January = 32;
    private byte _February = 29;
    private byte _March = 32;
    private byte _April = 31;
    private byte _May = 32;
    private byte _June = 31;
    private byte _July = 32;
    private byte _August = 32;
    private byte _September = 31;
    private byte _October = 32;
    private byte _November = 31;
    private byte _December = 32;


    private void Start()
    {
        StartCoroutine(DataCoroutine());
        TextData();
        if (Year <= 2018) Year = 2018;   
    }
   
    private void TextData()
    {
        TextDay.text = Day.ToString();
        TextMonth.text = Month.ToString();
        TextYear.text = Year.ToString();
    }  

    private IEnumerator DataCoroutine()
    {
        while(true)
        {            
            if (!_functionPanelButton.MainPanel.activeSelf) Day++; //Прибавляем +1 день к переменной дня    
           
            MonthMethod(); //Тут хранятся все месяца и условия для них
            TextData(); //Тут хранятся присваивания текста к переменной для отображения переменной
            
            if (Year >= 2050) { Debug.Log("Вы прошли игру"); }

            if (Month >= 12) { Year++; Day = 1; Month = 1; }

            if (Day <= 9) { TextDay.text = "0" + Day; }

            if (Month <= 9) { TextMonth.text = "0" + Month; }

            if (Year == Random.Range(2022, 2024))
                if (Month == Random.Range(1, 12)) { if (Day == Random.Range(1, 27)) { _crisis.ActiveCrisis = true; } }

            if (Year == Random.Range(2027, 2030))
                if (Month == Random.Range(1, 12)) { if (Day == Random.Range(1, 27)) { _crisis.ActiveCrisis = true; } }

            if (Year == Random.Range(2034, 2040))
                if (Month == Random.Range(1, 12)) { if (Day == Random.Range(1, 27)) { _crisis.ActiveCrisis = true; } }

            _mainGameMechanicsAccess.Money -= _mainGameMechanicsAccess.ExpenditureStaff;
            yield return new WaitForSeconds(1);
        }
    }
    private void MonthMethod()
    {     
        if (Month == 1) { if (Day >= 31) { Day = 1; Month++; } }
        if (Month == 2) { if (Day >= 28) { Day = 1; Month++; } }
        if (Month == 3) { if (Day > 30) { Day = 1; Month++; } }
        if (Month == 4) { if (Day > 30) { Day = 1; Month++; } }
        if (Month == 5) { if (Day >= 31) { Day = 1; Month++; } }
        if (Month == 6) { if (Day >= 30) { Day = 1; Month++; } }
        if (Month == 7) { if (Day >= 31) { Day = 1; Month++; } }
        if (Month == 8) { if (Day >= 31) { Day = 1; Month++; } }
        if (Month == 9) { if (Day >= 30) { Day = 1; Month++; } }
        if (Month == 10) { if (Day >= 31) { Day = 1; Month++; } }
        if (Month == 11) { if (Day >= 30) { Day = 1; Month++; } }
        if (Month == 12) { if (Day >= 31) { Day = 1; Month++; } }      
    } 
}
