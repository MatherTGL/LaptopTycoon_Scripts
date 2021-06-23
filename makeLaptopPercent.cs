using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class makeLaptopPercent : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private RatingCreate _ratingCreate;
    [SerializeField] private CostSliderSettings _costSliderSettings;
    [SerializeField] private adsManagerScr _adsManager;

    [Header("Процент от баланса")]
    [SerializeField] private float _percentMakeLaptop;
    [Header("Сколько вышло по цене копии")]
    [SerializeField] private double _costFullCopies;

    public GameObject panelPercentMake;

    [SerializeField] private Text _textCopiesLaptop;
    [SerializeField] private Text _textCreateMinesLaptop;
    [SerializeField] private Text _textCostCreateCopies;
    [SerializeField] private Text _textAllMoneyPlayer;

    [SerializeField] private double _copiesLaptop;
    [SerializeField] private double _plusMoneyPlayerCreate;

    private void OnEnable()
    {
        _costFullCopies = _mainGameMechanics.Money * _percentMakeLaptop;
        _copiesLaptop = _costFullCopies / _mainGameMechanics.FullZeroCostLaptop;
        _mainGameMechanics.retailPrice = (int)_costSliderSettings.costSliderLaptop.value;
        _plusMoneyPlayerCreate = _copiesLaptop * _mainGameMechanics.retailPrice / 1.3f;
        _textAllMoneyPlayer.text = "BUDGET $" + _mainGameMechanics.Money.ToString("#,#");
        _textCreateMinesLaptop.text = "CREATE -15%";
        _textCopiesLaptop.text = "COPIES " + _copiesLaptop.ToString("#,#");
        _textCostCreateCopies.text = "COST $" + _costFullCopies.ToString("#,#");
    }

    private void Update()
    {
        if (_createLaptop.deactivePanelMakeLaptop == 1) { panelPercentMake.SetActive(false); _createLaptop.TextPercentCreateLaptop.enabled = true; }

        if (_createLaptop.PercentCreateLaptop == 0) { if (_createLaptop.makeLaptopPanel.activeSelf) panelPercentMake.SetActive(true); }
        else panelPercentMake.SetActive(false);    
    }

    public void MakeLaptopButton() //Кнопка - сколько сделать копий
    {
        StartCoroutine(_createLaptop.CheckRatingLaptop()); 
        _createLaptop.deactivePanelMakeLaptop = 1;
        _mainGameMechanics.RecearchPoint += (ushort)Random.Range(20, 50);
        panelPercentMake.SetActive(false);
        _createLaptop.TextPercentCreateLaptop.enabled = true; //Текст с процентами готовности включаем   
        _createLaptop.makeImageLaptopPanel.enabled = false;
        if (Advertisement.IsReady()) { _adsManager.freeRPCreatingPanelButton.SetActive(true); }
    }
}
