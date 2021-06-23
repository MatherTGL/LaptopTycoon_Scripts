using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class adsManagerScr : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private SaveSystem _saveSystem;

    [SerializeField] private bool checkCompanyOneAd;
    [SerializeField] private bool checkCompanyThirdAd;
    [SerializeField] private bool checkZeroMoneyAd;
    [SerializeField] private bool checkFirstMoneyAd; //10000000000
    [SerializeField] private bool checkSecondMoneyAd; //100000000000
    [SerializeField] private bool checkThirdMoneyAd;

    [SerializeField] private byte checkCompanyOneNumber;
    [SerializeField] private byte checkCompanyThirdNumber;
    [SerializeField] private byte checkZeroMoneyNumber;
    [SerializeField] private byte checkFirstMoneyNumber;
    [SerializeField] private byte checkSecondMoneyNumber;
    [SerializeField] private byte checkThirdMoneyNumber;

    [SerializeField] private Text _textGetFreeMoney;
    [SerializeField] private Text _textGetFreeRP;

    public bool checkBuyAd;
    public byte checkNumberBuyAdsSave;

    public GameObject freeRPCreatingPanelButton;

    void Start()
    {
        if (PlayerPrefs.HasKey("checkCompanyOneAd")) { checkCompanyOneNumber = (byte)PlayerPrefs.GetInt("checkCompanyOneAd"); }
        if (PlayerPrefs.HasKey("checkCompanyThirdAd")) { checkCompanyThirdNumber = (byte)PlayerPrefs.GetInt("checkCompanyThirdAd"); }
        if (PlayerPrefs.HasKey("checkZeroMoneyAd")) { checkZeroMoneyNumber = (byte)PlayerPrefs.GetInt("checkZeroMoneyAd"); }
        if (PlayerPrefs.HasKey("checkFirstMoneyAd")) { checkFirstMoneyNumber = (byte)PlayerPrefs.GetInt("checkFirstMoneyAd"); }
        if (PlayerPrefs.HasKey("checkSecondMoneyAd")) { checkSecondMoneyNumber = (byte)PlayerPrefs.GetInt("checkSecondMoneyAd"); }
        if (PlayerPrefs.HasKey("checkThirdMoneyAd")) { checkThirdMoneyNumber = (byte)PlayerPrefs.GetInt("checkThirdMoneyAd"); }
        _textGetFreeRP.text = "GET FREE 30 RP";
        _textGetFreeMoney.text = "GET FREE $100 000 000";
        freeRPCreatingPanelButton.SetActive(false);
        if (PlayerPrefs.HasKey("buyAdsSave")) { checkNumberBuyAdsSave = (byte)PlayerPrefs.GetInt("buyAdsSave");}
        if (checkNumberBuyAdsSave == 1) { checkBuyAd = true; }
        StartCoroutine(checkAds());
        if (Advertisement.isSupported) { Advertisement.Initialize("3917875", false); }
    }

    void Update()
    {
        if (checkBuyAd != true)
        {
            if (checkCompanyOneNumber == 1) { checkCompanyOneAd = true; }
            if (checkCompanyThirdNumber == 1) { checkCompanyThirdAd = true; }
            if (checkZeroMoneyNumber == 1) { checkZeroMoneyAd = true; }
            if (checkFirstMoneyNumber == 1) { checkFirstMoneyAd = true; }
            if (checkSecondMoneyNumber == 1) { checkSecondMoneyAd = true; }
            if (checkThirdMoneyNumber == 1) { checkThirdMoneyAd = true; }
            checkAdsParametr();
        }
    }

    public void continueGameoOverAdCheck() { if (Advertisement.IsReady()) { Advertisement.Show("rewardedVideo"); } }

    public void freeMoneyButton() { if (Advertisement.IsReady()) { Advertisement.Show("rewardedVideo"); _mainGameMechanics.Money += 100000000; } }

    public void freeRPButton() { if (Advertisement.IsReady()) { Advertisement.Show("rewardedVideo"); _mainGameMechanics.RecearchPoint += 30; } }

    public void freeRPCreatingLaptopButton()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            _mainGameMechanics.RecearchPoint += 30;
            freeRPCreatingPanelButton.SetActive(false);
        }
    }


    private void checkAdsParametr()
    {       
        if (!_functionPanelButton.MainPanel.activeSelf | _saveSystem.loadingPanelStart)
        {
            if (checkBuyAd != true)
            {
                if (_createLaptop.ownLaptopCompany == 3) { StartCoroutine(checkAds()); }
                if (_mainGameMechanics.Money < 0) { StartCoroutine(checkAds()); }
                if (_mainGameMechanics.Money >= 10000000000) { StartCoroutine(checkAds()); }
                if (_mainGameMechanics.Money >= 100000000000) { StartCoroutine(checkAds()); }
                if (_mainGameMechanics.Money >= 1000000000000) { StartCoroutine(checkAds()); }
            }
        }
    }

    public void openAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }
    }

    IEnumerator checkAds()
    {
        while(true)
        {
            if (checkBuyAd != true)
            {
                if (!_functionPanelButton.MainPanel.activeSelf)
                {
                    if (_createLaptop.ownLaptopCompany == 2)
                    {
                        if (checkCompanyOneAd != true)
                        {
                            if (Advertisement.IsReady())
                            {
                                Advertisement.Show("video");
                                checkCompanyOneNumber = 1;
                                PlayerPrefs.SetInt("checkCompanyOneAd", checkCompanyOneNumber);
                                yield break;
                            }
                        }
                    }

                    if (_createLaptop.ownLaptopCompany == 4)
                    {
                        if (checkCompanyThirdAd != true)
                        {
                            if (Advertisement.IsReady())
                            {
                                Advertisement.Show("rewardedVideo");
                                checkCompanyThirdNumber = 1;
                                PlayerPrefs.SetInt("checkCompanyThirdAd", checkCompanyThirdNumber);
                                yield break;
                            }
                        }
                    }

                    if (_mainGameMechanics.Money >= 10000000000)
                    {
                        if (checkFirstMoneyAd != true)
                        {
                            if (Advertisement.IsReady())
                            {
                                Advertisement.Show("video");
                                checkFirstMoneyNumber = 1;
                                PlayerPrefs.SetInt("checkFirstMoneyAd", checkFirstMoneyNumber);
                                yield break;
                            }
                        }
                    }

                    if (_mainGameMechanics.Money >= 100000000000)
                    {
                        if (checkSecondMoneyAd != true)
                        {
                            if (Advertisement.IsReady())
                            {
                                Advertisement.Show("video");
                                checkSecondMoneyNumber = 1;
                                PlayerPrefs.SetInt("checkSecondMoneyAd", checkSecondMoneyNumber);
                                yield break;
                            }
                        }
                    }

                    if (_mainGameMechanics.Money >= 1000000000000)
                    {
                        if (checkThirdMoneyAd != true)
                        {
                            if (Advertisement.IsReady())
                            {
                                Advertisement.Show("rewardedVideo");
                                checkThirdMoneyNumber = 1;
                                PlayerPrefs.SetInt("checkThirdMoneyAd", checkThirdMoneyNumber);
                                yield break;
                            }
                        }
                    }

                    if (_mainGameMechanics.Money < 0)
                    {
                        if (Advertisement.IsReady())
                        {
                            if (checkZeroMoneyAd != true)
                            {
                                Advertisement.Show("video");
                                checkZeroMoneyNumber = 1;
                                PlayerPrefs.SetInt("checkZeroMoneyAd", checkZeroMoneyNumber);
                                yield break;
                            }
                        }
                    }
                }
                yield return new WaitForSeconds(1);
            }        
        }
    }
}
