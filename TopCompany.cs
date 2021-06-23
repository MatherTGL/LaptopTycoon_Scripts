using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TopCompany : MonoBehaviour
{
    [Header("Доступ к другим компаниям")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CompanyNameInputField _companyNameInputField;
    [SerializeField] private FunctionPanelButton _functionPanelButton;

    [Header("Капитализация компаний")]
    public double capitalizationCompany;
    [SerializeField] private Text _textCapitalizationCompanyPlayer;
    public double funsCompany;
    [SerializeField] private Text _textFunsCompanyPlayer;
    public string nameCompany;
    [SerializeField] private Text _textNameCompanyPlayer;
    [SerializeField] private GameObject _panelTopCompanyPlayer;
    [SerializeField] private Image _lineTopCompanyPanel;

    [Header("другие компании (5)")]
    [SerializeField] private Text _textFiveCapitalizationCompany;
    [SerializeField] private Text _textFiveFunsCompany;
    [SerializeField] private Text _textFiveNameCompany;

    [Header("другие компании (4)")]
    [SerializeField] private Text _textFourthCapitalizationCompany;
    [SerializeField] private Text _textFourthFunsCompany;
    [SerializeField] private Text _textFouthNameCompany;

    [Header("другие компании (3)")]
    [SerializeField] private Text _textThreeCapitalizationCompany;
    [SerializeField] private Text _textThreeFunsCompany;
    [SerializeField] private Text _textThreeNameCompany;

    [Header("другие компании (2)")]
    [SerializeField] private Text _textSecondCapitalizationCompany;
    [SerializeField] private Text _textSecondFunsCompany;
    [SerializeField] private Text _textSecondNameCompany;

    [Header("другие компании (1)")]
    [SerializeField] private Text _textFirstCapitalizationCompany;
    [SerializeField] private Text _textFirstFunsCompany;
    [SerializeField] private Text _textFirstNameCompany;

    void Awake()
    {
        StartCoroutine(checkPlayerCompanyTop());
        nameCompany = _companyNameInputField.NameCompany;

        if (capitalizationCompany < 328412418591)
        {
            _lineTopCompanyPanel.enabled = true;
            _panelTopCompanyPlayer.SetActive(true);
            _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
            _textFunsCompanyPlayer.text = _mainGameMechanics.Fun.ToString();
            _textFiveCapitalizationCompany.text = "$328 B";
            _textFiveFunsCompany.text = "80M";
            _textFiveNameCompany.text = "#5 XERNA";
            if (_mainGameMechanics.Money > 1000000000) { _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B"); }
            else { _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#.#"); }                
            _textNameCompanyPlayer.text = "#6 " + nameCompany;
        }
        if (capitalizationCompany > 328412418591)
        {
            _lineTopCompanyPanel.enabled = false;
            _textFiveCapitalizationCompany.text = "$" + _mainGameMechanics.Money.ToString("#,,,B");
            _textFiveFunsCompany.text = _mainGameMechanics.Fun.ToString();
            _textFiveNameCompany.text = "#5 " + _companyNameInputField.NameCompany;
            _panelTopCompanyPlayer.SetActive(false);
        }

        if (capitalizationCompany < 534701432951 & capitalizationCompany > 328412418591)
        {
            _textFiveCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
            _textFiveFunsCompany.text = _mainGameMechanics.Fun.ToString();
            _textFiveNameCompany.text = "#5 " + _companyNameInputField.NameCompany;
            _textFourthCapitalizationCompany.text = "$534 B";
            _textFourthFunsCompany.text = "151 M";
            _textFouthNameCompany.text = "#4 PIPEC";
        }

        if (capitalizationCompany > 534701432951)
        {
            _textFourthCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
            _textFourthFunsCompany.text = _mainGameMechanics.Fun.ToString();
            _textFouthNameCompany.text = "#4 " + _companyNameInputField.NameCompany;
            _textFiveCapitalizationCompany.text = "$328 B";
            _textFiveFunsCompany.text = "80 M";
            _textFiveNameCompany.text = "#5 PIPEC";
        }
        if (capitalizationCompany > 834472234942)
        {
            _textThreeCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
            _textThreeFunsCompany.text = _mainGameMechanics.Fun.ToString();
            _textThreeNameCompany.text = "#3 " + _companyNameInputField.NameCompany;
            _textFouthNameCompany.text = "#4 XEROS";
            _textFourthFunsCompany.text = "151 M";
            _textFourthCapitalizationCompany.text = "$534 B";
            _textFiveCapitalizationCompany.text = "$328 B";
            _textFiveFunsCompany.text = "80 M";
            _textFiveNameCompany.text = "#5 PIPEC";
        }
        if (capitalizationCompany > 998546491536)
        {
            _textSecondCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
            _textSecondFunsCompany.text = _mainGameMechanics.Fun.ToString("#,,M");
            _textSecondNameCompany.text = "#2 " + _companyNameInputField.NameCompany;
            _textThreeCapitalizationCompany.text = "$834B";
            _textThreeFunsCompany.text = "186 M";
            _textThreeNameCompany.text = "#3 KOCO";
            _textFouthNameCompany.text = "#4 XEROS";
            _textFourthFunsCompany.text = "151 M";
            _textFourthCapitalizationCompany.text = "$534 B";
            _textFiveCapitalizationCompany.text = "$328 B";
            _textFiveFunsCompany.text = "80 M";
            _textFiveNameCompany.text = "#5 PIPEC";
        }
        if (capitalizationCompany > 1104548456857)
        {
            _textFirstCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,,T");
            _textFirstFunsCompany.text = _mainGameMechanics.Fun.ToString();
            _textFirstNameCompany.text = "#1 " + _companyNameInputField.NameCompany;
            _textSecondCapitalizationCompany.text = "$998 B";
            _textSecondFunsCompany.text = "178 M";
            _textSecondNameCompany.text = "#2 OCTAV";
            _textThreeCapitalizationCompany.text = "$834B";
            _textThreeFunsCompany.text = "186 M";
            _textThreeNameCompany.text = "#3 KOCO";
            _textFouthNameCompany.text = "#4 XEROS";
            _textFourthFunsCompany.text = "151 M";
            _textFourthCapitalizationCompany.text = "$534 B";
            _textFiveCapitalizationCompany.text = "$328 B";
            _textFiveFunsCompany.text = "80 M";
            _textFiveNameCompany.text = "#5 PIPEC";
        }
    }

    private void Update()
    {
        if (nameCompany != "")
        {
            capitalizationCompany = _mainGameMechanics.Money;
            funsCompany = _mainGameMechanics.Fun;
            _textFunsCompanyPlayer.text = _mainGameMechanics.Fun.ToString();
            if (_mainGameMechanics.Money > 1000000000) { _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B"); }
            else if (_mainGameMechanics.Money < 1000000000) { _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#.#"); }
            else if (_mainGameMechanics.Money > 1000000000000) { _textCapitalizationCompanyPlayer.text = "$" + capitalizationCompany.ToString("#,,,,T"); }               
        }       
    }

    private IEnumerator checkPlayerCompanyTop()
    {
        while(true)
        {
            if (_functionPanelButton.topCompanyPanel.activeSelf)
            {
                if (nameCompany != "")
                {
                    if (capitalizationCompany < 328412418591)
                    {
                        _lineTopCompanyPanel.enabled = true;
                        _panelTopCompanyPlayer.SetActive(true);
                        _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textFunsCompanyPlayer.text = _mainGameMechanics.Fun.ToString();
                        _textFiveCapitalizationCompany.text = "$328 B";
                        _textFiveFunsCompany.text = "80M";
                        _textFiveNameCompany.text = "#5 XERNA";
                        if (_mainGameMechanics.Money > 1000000000) { _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B"); }                             
                        else { _textCapitalizationCompanyPlayer.text = "$ " + _mainGameMechanics.Money.ToString("#.#"); }                           
                        _textNameCompanyPlayer.text = "#6 " + nameCompany;
                    }
                    if (capitalizationCompany > 328412418591)
                    {
                        _lineTopCompanyPanel.enabled = false;
                        _textFiveCapitalizationCompany.text = "$" + _mainGameMechanics.Money.ToString("#,,,B");
                        _textFiveFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textFiveNameCompany.text = "#5 " + _companyNameInputField.NameCompany;
                        _panelTopCompanyPlayer.SetActive(false);
                    }
                    
                    if (capitalizationCompany < 534701432951 & capitalizationCompany > 328412418591)
                    {
                        _textFiveCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textFiveFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textFiveNameCompany.text = "#5 " + _companyNameInputField.NameCompany;
                        _textFourthCapitalizationCompany.text = "$534 B";
                        _textFourthFunsCompany.text = "151 M";
                        _textFouthNameCompany.text = "#4 PIPEC";
                    }

                    if (capitalizationCompany > 534701432951)
                    {
                        _textFourthCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textFourthFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textFouthNameCompany.text = "#4 " + _companyNameInputField.NameCompany;
                        _textFiveCapitalizationCompany.text = "$534 B";
                        _textFiveFunsCompany.text = "151 M";
                        _textFiveNameCompany.text = "#5 PIPEC";
                    }

                    if (capitalizationCompany < 834472234942 & capitalizationCompany > 534701432951)
                    {
                        _textFourthCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textFourthFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textFouthNameCompany.text = "#4 " + _companyNameInputField.NameCompany;
                        _textThreeCapitalizationCompany.text = "$834 B";
                        _textThreeFunsCompany.text = "186 M";
                        _textThreeNameCompany.text = "#3 XEROS";
                    }

                    if (capitalizationCompany > 834472234942)
                    {
                        _textThreeCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textThreeFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textThreeNameCompany.text = "#3 " + _companyNameInputField.NameCompany;
                        _textFouthNameCompany.text = "#4 XEROS";
                        _textFourthFunsCompany.text = "186 M";
                        _textFourthCapitalizationCompany.text = "$834 B";
                        _textFiveCapitalizationCompany.text = "$534 B";
                        _textFiveFunsCompany.text = "151 M";
                        _textFiveNameCompany.text = "#5 PIPEC";
                    }

                    if (capitalizationCompany < 998546491536 & capitalizationCompany > 834472234942)
                    {
                        _textThreeCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textThreeFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textThreeNameCompany.text = "#3 " + _companyNameInputField.NameCompany;
                        _textSecondCapitalizationCompany.text = "$998 B";
                        _textSecondFunsCompany.text = "178 M";
                        _textSecondNameCompany.text = "#2 KOCO";
                    }

                    if (capitalizationCompany > 998546491536)
                    {
                        _textSecondCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textSecondFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textSecondNameCompany.text = "#2 " + _companyNameInputField.NameCompany;
                        _textThreeCapitalizationCompany.text = "$834B";
                        _textThreeFunsCompany.text = "186 M";
                        _textThreeNameCompany.text = "#3 KOCO";
                        _textFouthNameCompany.text = "#4 XEROS";
                        _textFourthFunsCompany.text = "151 M";
                        _textFourthCapitalizationCompany.text = "$534 B";
                        _textFiveCapitalizationCompany.text = "$328 B";
                        _textFiveFunsCompany.text = "80 M";
                        _textFiveNameCompany.text = "#5 PIPEC";
                    }

                    if (capitalizationCompany < 1104548456857 & capitalizationCompany > 998546491536)
                    {
                        _textSecondCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,B");
                        _textSecondFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textSecondNameCompany.text = "#2 " + _companyNameInputField.NameCompany;
                        _textFirstCapitalizationCompany.text = "$1.14 T";
                        _textFirstFunsCompany.text = "191 M";
                        _textFirstNameCompany.text = "#1 OCTAV";
                    }

                    if (capitalizationCompany > 1104548456857)
                    {
                        _textFirstCapitalizationCompany.text = "$ " + _mainGameMechanics.Money.ToString("#,,,,T");
                        _textFirstFunsCompany.text = _mainGameMechanics.Fun.ToString();
                        _textFirstNameCompany.text = "#1 " + _companyNameInputField.NameCompany;
                        _textSecondCapitalizationCompany.text = "$998 B";
                        _textSecondFunsCompany.text = "178 M";
                        _textSecondNameCompany.text = "#2 OCTAV";
                        _textThreeCapitalizationCompany.text = "$834B";
                        _textThreeFunsCompany.text = "186 M";
                        _textThreeNameCompany.text = "#3 KOCO";
                        _textFouthNameCompany.text = "#4 XEROS";
                        _textFourthFunsCompany.text = "151 M";
                        _textFourthCapitalizationCompany.text = "$534 B";
                        _textFiveCapitalizationCompany.text = "$328 B";
                        _textFiveFunsCompany.text = "80 M";
                        _textFiveNameCompany.text = "#5 PIPEC";
                    }
                }
                yield return new WaitForSeconds(1);
            }                   
        }
    }
}
