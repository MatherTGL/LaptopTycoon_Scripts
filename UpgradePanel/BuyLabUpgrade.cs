using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyLabUpgrade : MonoBehaviour
{
    [SerializeField] private Laboratory _laboratory;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    public byte saveLabBuy; //Сохранение покупки лабы

    [Header("UI")]
    [SerializeField] private Text _textCostUpgrade;
    [SerializeField] private Image _arrowUpgrade;
    [SerializeField] private Image _mainArrowCyrcle;
    [SerializeField] private Color _greenColor;
    [SerializeField] private Color _redColor;

    private void Start()
    {
        _laboratory.TextExpenditureLaboratory.text = "$" + _laboratory.ExpenditureLaboratory.ToString("#,#") + " / 10 Days";
        _laboratory.TextIncomeLaboratory.text = _laboratory.IncomeLaboratoryRP + " RP" + " / 10 Days";
        if (saveLabBuy == 1)
        {
            _laboratory._InfoLab.SetActive(true);
            _laboratory._BuyLab.SetActive(false);
        }
        else { _laboratory._InfoLab.SetActive(false); _laboratory._BuyLab.SetActive(true); }
    }

    private void Update()
    {
        if (_laboratory.IncomeLaboratoryRP == 3)
        {
            if (_mainGameMechanics.Money >= 15000000)
            {
                _arrowUpgrade.color = _greenColor;
                _textCostUpgrade.color = _greenColor;
            }
            else { _arrowUpgrade.color = _redColor; _textCostUpgrade.color = _redColor; }
        }
        else if (_laboratory.IncomeLaboratoryRP == 5)
        {
            if (_mainGameMechanics.Money >= 20000000)
            {
                _arrowUpgrade.color = _greenColor;
                _textCostUpgrade.color = _greenColor;
            }
            else { _arrowUpgrade.color = _greenColor; _textCostUpgrade.color = _redColor; }
        }
        else if (_laboratory.IncomeLaboratoryRP == 8)
        {
            if (_mainGameMechanics.Money >= 25000000)
            {
                _arrowUpgrade.color = _greenColor;
                _textCostUpgrade.color = _greenColor;
            }
            else { _arrowUpgrade.color = _greenColor; _textCostUpgrade.color = _redColor; }
        }
        else { _textCostUpgrade.enabled = false; _mainArrowCyrcle.enabled = false; }
    }

    public void upgradeLab()
    {
        if (_laboratory.IncomeLaboratoryRP == 3)
        { 
            if (_mainGameMechanics.Money >= 15000000)
            {
                _laboratory.IncomeLaboratoryRP = 5;
                _laboratory.ExpenditureLaboratory = 12000000;
                _mainGameMechanics.Money -= 15000000;
                _laboratory.TextExpenditureLaboratory.text = "$" + _laboratory.ExpenditureLaboratory.ToString("#,#") + " / 10 Days";
                _laboratory.TextIncomeLaboratory.text = _laboratory.IncomeLaboratoryRP + " RP" + " / 10 Days";
                PlayerPrefs.SetInt("saveLab", saveLabBuy);
                PlayerPrefs.SetInt("incomeLabSave", _laboratory.IncomeLaboratoryRP);
                PlayerPrefs.SetInt("expenditureLabSave", (int)_laboratory.ExpenditureLaboratory);
            }
        }
        else if (_laboratory.IncomeLaboratoryRP == 5)
        {
            if (_mainGameMechanics.Money >= 20000000)
            {
                _laboratory.IncomeLaboratoryRP = 8;
                _laboratory.ExpenditureLaboratory = 14000000;
                _mainGameMechanics.Money -= 20000000;
                _laboratory.TextExpenditureLaboratory.text = "$" + _laboratory.ExpenditureLaboratory.ToString("#,#") + " / 10 Days";
                _laboratory.TextIncomeLaboratory.text = _laboratory.IncomeLaboratoryRP + " RP" + " / 10 Days";
                PlayerPrefs.SetInt("saveLab", saveLabBuy);
                PlayerPrefs.SetInt("incomeLabSave", _laboratory.IncomeLaboratoryRP);
                PlayerPrefs.SetInt("expenditureLabSave", (int)_laboratory.ExpenditureLaboratory);
            }
        }
        else if (_laboratory.IncomeLaboratoryRP == 8)
        {
            if (_mainGameMechanics.Money >= 25000000)
            {
                _laboratory.IncomeLaboratoryRP = 11;
                _laboratory.ExpenditureLaboratory = 17000000;
                _mainGameMechanics.Money -= 25000000;
                _laboratory.TextExpenditureLaboratory.text = "$" + _laboratory.ExpenditureLaboratory.ToString("#,#") + " / 10 Days";
                _laboratory.TextIncomeLaboratory.text = _laboratory.IncomeLaboratoryRP + " RP" + " / 10 Days";
                PlayerPrefs.SetInt("saveLab", saveLabBuy);
                PlayerPrefs.SetInt("incomeLabSave", _laboratory.IncomeLaboratoryRP);
                PlayerPrefs.SetInt("expenditureLabSave", (int)_laboratory.ExpenditureLaboratory);
            }
        }
    }

    public void buyLabButton()
    {
        if (_mainGameMechanics.Money >= 15000000000)
        {
            saveLabBuy++;
            _laboratory._InfoLab.SetActive(true);
            _laboratory._BuyLab.SetActive(false);
            _laboratory.ExpenditureLaboratory = 10000000;
            _laboratory.TextExpenditureLaboratory.text = "$" + _laboratory.ExpenditureLaboratory.ToString("#,#") + " / 10 Days";
            _laboratory.IncomeLaboratoryRP = 3;
            _laboratory.TextIncomeLaboratory.text = _laboratory.IncomeLaboratoryRP + " RP" + " / 10 Days";
            _mainGameMechanics.Money -= 15000000000;
            PlayerPrefs.SetInt("saveLab", saveLabBuy);
            PlayerPrefs.SetInt("incomeLabSave", _laboratory.IncomeLaboratoryRP);
            PlayerPrefs.SetInt("expenditureLabSave", (int)_laboratory.ExpenditureLaboratory);
        }
    }  
}
