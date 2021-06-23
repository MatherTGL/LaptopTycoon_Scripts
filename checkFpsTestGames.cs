using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkFpsTestGames : MonoBehaviour
{
    public string nameVideocard;
    public Text fisrtFps;
    public Text secondFps;
    public Text thirdFps;
    public Text fourthFos;
    public Text fifthFps;
    public Text sixthFps;
    public Text seventhFps;
    public Text eighthFps;

    [SerializeField] private videocardData _videocardData;

    [SerializeField] private Text _settingFisrtFps;
    [SerializeField] private Text _settingSecondFps;
    [SerializeField] private Text _settingThirdFps;
    [SerializeField] private Text _settingFourthFps;
    [SerializeField] private Text _settingFifthFps;
    [SerializeField] private Text _settingSixthFps;
    [SerializeField] private Text _settingSeventhFps;
    [SerializeField] private Text _settingEighthFps;

    [Header("Цвета фпс")]
    [SerializeField] private Color _greenColor;
    [SerializeField] private Color _lightGreenColor;
    [SerializeField] private Color _orangeColor;
    [SerializeField] private Color _redColor;

    [SerializeField] private Text _gamesTestDropdown;

    [Header("Панели игр")]
    [SerializeField] private GameObject _gtaPanelTest;
    [SerializeField] private GameObject _farcryPanelTest;
    [SerializeField] private GameObject _mfsPanelTest;
    [SerializeField] private GameObject _witcherPanelTest;
    [SerializeField] private GameObject _csgoPanelTest;

    public byte checkActiveSli;
    [SerializeField] private bool _checkBoolActiveSli;

    void Update()
    {
        if (checkActiveSli == 1) { _checkBoolActiveSli = true; }
        else { _checkBoolActiveSli = false; }
        
        if (_gamesTestDropdown.text == "GTO V")
        {
            _gtaPanelTest.SetActive(true);
            _farcryPanelTest.SetActive(false);
            _mfsPanelTest.SetActive(false);
            _witcherPanelTest.SetActive(false);
            _csgoPanelTest.SetActive(false);

            if (nameVideocard == "RYX 550")
            {
                fifthFps.enabled = true;
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "";

                fisrtFps.text = "85-90";
                fisrtFps.color = _greenColor;
                secondFps.text = "75-80";
                secondFps.color = _greenColor;
                thirdFps.text = "30-33";
                thirdFps.color = _lightGreenColor;
                fourthFos.text = "12-14";
                fourthFos.color = _redColor;
                fifthFps.text = "4-5";
                fifthFps.color = _redColor;
                sixthFps.enabled = false;
            }
            if (nameVideocard == "MGX 1050")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "Ultra / 4k";

                fisrtFps.text = "120-130";
                fisrtFps.color = _greenColor;
                secondFps.text = "110-120";
                secondFps.color = _greenColor;
                thirdFps.text = "55-60";
                thirdFps.color = _greenColor;
                fourthFos.text = "24-27";
                fourthFos.color = _orangeColor;
                fifthFps.text = "14-16";
                fifthFps.color = _redColor;
                sixthFps.text = "4-8";
                sixthFps.color = _redColor;
                sixthFps.enabled = true;
            }
            if (nameVideocard == "MGX 1050 TI")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "Ultra / 4k";

                fisrtFps.text = "140-150";
                fisrtFps.color = _greenColor;
                secondFps.text = "120-130";
                secondFps.color = _greenColor;
                thirdFps.text = "65-70";
                thirdFps.color = _greenColor;
                fourthFos.text = "30-33";
                fourthFos.color = _orangeColor;
                fifthFps.text = "18-20";
                fifthFps.color = _redColor;
                sixthFps.text = "6-9";
                sixthFps.color = _redColor;
                sixthFps.enabled = true;
            }
            if (nameVideocard == "MGX 1650")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "Ultra / 4k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "210-220";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "190-200";
                    secondFps.color = _greenColor;
                    thirdFps.text = "100-110";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "50-60";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "32-40";
                    fifthFps.color = _orangeColor;
                    sixthFps.text = "15-20";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "150-160";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "140-150";
                    secondFps.color = _greenColor;
                    thirdFps.text = "75-80";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "35-40";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "24-27";
                    fifthFps.color = _orangeColor;
                    sixthFps.text = "11-15";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }    
            }
            if (nameVideocard == "MGX 1060")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "Ultra / 4k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300-315";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "225-240";
                    secondFps.color = _greenColor;
                    thirdFps.text = "165-170";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "90-100";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-50";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "25-30";
                    sixthFps.color = _orangeColor;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "65-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "30-35";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "15-20";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "MGX 1070 TI")
            {
                _settingFisrtFps.text = "Low / 1080p";
                _settingSecondFps.text = "Average / 1080p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "Ultra / 4k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "220-235";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "200-210";
                    secondFps.color = _greenColor;
                    thirdFps.text = "165-175";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "90-100";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "50-60";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "35-40";
                    sixthFps.color = _lightGreenColor ;
                }
                else
                {
                    fisrtFps.text = "160-170";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "140-150";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "65-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "35-45";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "20-25";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2060")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "High / 1080p";
                _settingThirdFps.text = "Ultra / 1080p";
                _settingFourthFps.text = "Ultra / 1440p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "Ultra / 5k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "240-250";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "220-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "160-170";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "100-110";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "45-50";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "25-30";
                    sixthFps.color = _orangeColor;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "75-80";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "25-30";
                    fifthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "15-20";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "RGX 2060s")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "240-250";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "220-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "160-170";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "55-65";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "30-40";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "10-17";
                    sixthFps.color = _redColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "30-35";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "20-25";
                    fifthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "6-10";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "RGX 2070")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "235-245";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "220-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "165-173";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "45-50";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "33-40";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "16-20";
                    sixthFps.color = _redColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "32-38";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "24-33";
                    fifthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "8-14";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "RGX 2070s")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "300-310";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "220-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "100-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-50"; //в 4к
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "16-23";
                    sixthFps.color = _redColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "70-100";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "40-50";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "30-38"; //в 4к
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "12-18";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "RGX 2080 TI")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "235-250";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "215-225";
                    secondFps.color = _greenColor;
                    thirdFps.text = "100-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "80-85";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "55-60"; //в 4к
                    fifthFps.color = _greenColor;
                    sixthFps.text = "30-35";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "85-110";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-65";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-50"; //в 4к
                    fifthFps.color = _lightGreenColor;
                    sixthFps.text = "20-28";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }              
            }
            if (nameVideocard == "RGX 3070")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "230-240";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "225-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "95-100";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "80-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-45";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.text = "15-20";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "70-80";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "30-39";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.text = "10-15";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }             
            }
            if (nameVideocard == "RGX 3070s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "240-255";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "220-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "115-123";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "100-110";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "60-65";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "28-37";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "80-90";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "70-78";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-50";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.text = "20-25";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }               
            }
            if (nameVideocard == "RGX 3080")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "240-255";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "225-240";
                    secondFps.color = _greenColor;
                    thirdFps.text = "125-135";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "100-110";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "80-90";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "40-50";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "90-105";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "75-85";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "55-60";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "30-37";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }               
            }
            if (nameVideocard == "RGX 3080s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "240-250";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "220-235";
                    secondFps.color = _greenColor;
                    thirdFps.text = "145-160";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "125-140";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "90-100";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "55-60";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "100-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "90-100";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "65-78";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "40-45";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3090")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "240-255";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "230-250";
                    secondFps.color = _greenColor;
                    thirdFps.text = "170-185";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "140-150";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "100-110";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "70-80";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "100-115";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "70-84";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "50-60";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }   
            }
            if (nameVideocard == "RGX 3090s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "245-270";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "240-250";
                    secondFps.color = _greenColor;
                    thirdFps.text = "200-215";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "170-185";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "120-130";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "85-95";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "170-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "160-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "140-150";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "120-130";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "90-100";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "60-80";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }               
            }
        }
        if (_gamesTestDropdown.text == "MGS 2020")
        {
            _gtaPanelTest.SetActive(false);
            _farcryPanelTest.SetActive(false);
            _mfsPanelTest.SetActive(true);
            _witcherPanelTest.SetActive(false);
            _csgoPanelTest.SetActive(false);
        }
        if (_gamesTestDropdown.text == "Wircher 3")
        {
            _gtaPanelTest.SetActive(false);
            _farcryPanelTest.SetActive(false);
            _mfsPanelTest.SetActive(false);
            _witcherPanelTest.SetActive(true);
            _csgoPanelTest.SetActive(false);

            if (nameVideocard == "RYX 550")
            {
                fifthFps.enabled = true;
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "";

                fisrtFps.text = "50-55";
                fisrtFps.color = _greenColor;
                secondFps.text = "30-35";
                secondFps.color = _orangeColor;
                thirdFps.text = "18-20";
                thirdFps.color = _redColor;
                fourthFos.text = "10-11";
                fourthFos.color = _redColor;
                fifthFps.text = "5-6";
                fifthFps.color = _redColor;
                sixthFps.enabled = false;
            }
            if (nameVideocard == "MGX 1050")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "";

                fisrtFps.text = "100−110";
                fisrtFps.color = _greenColor;
                secondFps.text = "65−70";
                secondFps.color = _greenColor;
                thirdFps.text = "35−40";
                thirdFps.color = _lightGreenColor;
                fourthFos.text = "21−24";
                fourthFos.color = _orangeColor;
                fifthFps.text = "12−14";
                fifthFps.color = _redColor;
                sixthFps.text = "";
                sixthFps.color = _redColor;
                sixthFps.enabled = true;
            }
            if (nameVideocard == "MGX 1050 TI")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "";

                fisrtFps.text = "120−130";
                fisrtFps.color = _greenColor;
                secondFps.text = "80−85";
                secondFps.color = _greenColor;
                thirdFps.text = "45−50";
                thirdFps.color = _lightGreenColor;
                fourthFos.text = "24−27";
                fourthFos.color = _orangeColor;
                fifthFps.text = "16−18";
                fifthFps.color = _redColor;
                sixthFps.text = "";
                sixthFps.color = _redColor;
                sixthFps.enabled = true;
            }
            if (nameVideocard == "MGX 1650")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "190-200";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "70-75";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "40-50";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "26-30";
                    fifthFps.color = _orangeColor;
                    sixthFps.text = "";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "150−160";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "100−105";
                    secondFps.color = _greenColor;
                    thirdFps.text = "55−60";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "30−35";
                    fourthFos.color = _orangeColor;
                    fifthFps.text = "20−22";
                    fifthFps.color = _orangeColor;
                    sixthFps.text = "";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "MGX 1060")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "240-250";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "170-185";
                    secondFps.color = _greenColor;
                    thirdFps.text = "97-110";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "50-60";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "35-40";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _orangeColor;
                }
                else
                {
                    fisrtFps.text = "190−200";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "75−80";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "40−45";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "27−30";
                    fifthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "MGX 1070 TI")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 1080p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "230-240";
                    secondFps.color = _greenColor;
                    thirdFps.text = "130-145";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "78-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "52-65";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fisrtFps.text = "250−260";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "180−190";
                    secondFps.color = _greenColor;
                    thirdFps.text = "100−110";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60−65";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40−45";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2060")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "High / 1080p";
                _settingThirdFps.text = "Ultra / 1080p";
                _settingFourthFps.text = "Ultra / 1440p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "Ultra / 5k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "260-270";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "78-85";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "65-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "52-60";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "39-46";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fisrtFps.text = "200-210";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "100-110";
                    secondFps.color = _greenColor;
                    thirdFps.text = "60-65";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "50-58";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-45";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "30-37";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2060s")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "280-290";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "97-110";
                    secondFps.color = _greenColor;
                    thirdFps.text = "80-90";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "45-50";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "20-25";
                    sixthFps.color = _orangeColor;
                }

                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "220-230";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "75-80";
                    secondFps.color = _greenColor;
                    thirdFps.text = "63-70";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "43-55";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "35-40";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "15-20";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "RGX 2070")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "90-100";
                    secondFps.color = _greenColor;
                    thirdFps.text = "85-90";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "65-75";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "52-60";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "33-40";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "240-250";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "75-80";
                    secondFps.color = _greenColor;
                    thirdFps.text = "70-75";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "50-60";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "40-50";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "26-30";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2070s")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "120-125";
                    secondFps.color = _greenColor;
                    thirdFps.text = "108-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "78-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "66-75"; //в 4к
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "41-46";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "270-280";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "100-110";
                    secondFps.color = _greenColor;
                    thirdFps.text = "90-100";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "65-80";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "55-60";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "33-40";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2080 TI")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "156-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "126-140";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "90-100";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "78-87"; 
                    fifthFps.color = _greenColor;
                    sixthFps.text = "50-55";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-145";
                    secondFps.color = _greenColor;
                    thirdFps.text = "105-120";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "75-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "65-70"; 
                    fifthFps.color = _greenColor;
                    sixthFps.text = "40-46";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3070")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "162-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "106-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "87-95";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "68-80";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "30-34";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "130-150";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "105-120";
                    secondFps.color = _greenColor;
                    thirdFps.text = "85-94";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "70-80";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "55-70";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "25-30";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3070s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "200-210";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "165-180";
                    secondFps.color = _greenColor;
                    thirdFps.text = "130-140";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "105-120";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "85-100";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "40-45";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "160-175";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "105-120";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "85-95";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "68-80";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "30-36";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3080")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "225-240";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "185-200";
                    secondFps.color = _greenColor;
                    thirdFps.text = "145-160";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "115-130";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "96-110";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "44-56";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "190-210";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "155-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "120-130";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "96-105";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "80-90";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "37-45";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3080s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "270-285";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "215-230";
                    secondFps.color = _greenColor;
                    thirdFps.text = "170-190";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "138-150";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "113-130";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "54-60";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "225-240";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "185-200";
                    secondFps.color = _greenColor;
                    thirdFps.text = "144-160";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "115-130";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "96-110";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "45-53";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3090")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "250-260";
                    secondFps.color = _greenColor;
                    thirdFps.text = "195-210";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "158-170";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "130-140";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "63-70";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "258-270";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "210-225";
                    secondFps.color = _greenColor;
                    thirdFps.text = "165-180";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "132-150";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "110-120";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "51-60";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3090s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "300+";
                    secondFps.color = _greenColor;
                    thirdFps.text = "235-250";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "190-205";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "150-160";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "75-90";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "250-260";
                    secondFps.color = _greenColor;
                    thirdFps.text = "195-210";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "158-170";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "132-145";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "61-70";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
            }
        }
        if (_gamesTestDropdown.text == "Fer Cry 3")
        {
            _gtaPanelTest.SetActive(false);
            _farcryPanelTest.SetActive(true);
            _mfsPanelTest.SetActive(false);
            _witcherPanelTest.SetActive(false);
            _csgoPanelTest.SetActive(false);

            if (nameVideocard == "RYX 550")
            {
                fifthFps.enabled = true;
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 768p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "";
                _settingSixthFps.text = "";

                fisrtFps.text = "85-90";
                fisrtFps.color = _greenColor;
                secondFps.text = "70-75";
                secondFps.color = _greenColor;
                thirdFps.text = "45-50";
                thirdFps.color = _lightGreenColor;
                fourthFos.text = "16-18";
                fourthFos.color = _redColor;
                fifthFps.text = "";
                fifthFps.color = _redColor;
                sixthFps.enabled = false;
            }
            if (nameVideocard == "MGX 1050")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 768p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "";
                _settingSixthFps.text = "";

                fisrtFps.text = "110-120";
                fisrtFps.color = _greenColor;
                secondFps.text = "100-110";
                secondFps.color = _greenColor;
                thirdFps.text = "70-75";
                thirdFps.color = _greenColor;
                fourthFos.text = "30-35";
                fourthFos.color = _orangeColor;
                fifthFps.text = "";
                fifthFps.color = _redColor;
                sixthFps.text = "";
                sixthFps.color = _redColor;
                sixthFps.enabled = true;
            }
            if (nameVideocard == "MGX 1050 TI")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 768p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "";
                _settingSixthFps.text = "";

                fisrtFps.text = "110-120";
                fisrtFps.color = _greenColor;
                secondFps.text = "100-110";
                secondFps.color = _greenColor;
                thirdFps.text = "80-85";
                thirdFps.color = _greenColor;
                fourthFos.text = "35-40";
                fourthFos.color = _orangeColor;
                fifthFps.text = "";
                fifthFps.color = _redColor;
                sixthFps.text = "";
                sixthFps.color = _redColor;
                sixthFps.enabled = true;
            }
            if (nameVideocard == "MGX 1650")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 768p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "";
                _settingSixthFps.text = "";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "150-155";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "117-124";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-70";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "";
                    fifthFps.color = _orangeColor;
                    sixthFps.text = "";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "110-120";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "100-110";
                    secondFps.color = _greenColor;
                    thirdFps.text = "85-90";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "45-50";
                    fourthFos.color = _lightGreenColor;
                    fifthFps.text = "";
                    fifthFps.color = _orangeColor;
                    sixthFps.text = "";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "MGX 1060")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 768p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "";
                _settingSixthFps.text = "";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "165-180";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "150-161";
                    secondFps.color = _greenColor;
                    thirdFps.text = "130-134";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "80-87";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _orangeColor;
                }
                else
                {
                    fisrtFps.text = "120-130";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "110-120";
                    secondFps.color = _greenColor;
                    thirdFps.text = "95-100";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-65";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _redColor;
                }
            }
            if (nameVideocard == "MGX 1070 TI")
            {
                _settingFisrtFps.text = "Low / 768p";
                _settingSecondFps.text = "Average / 768p";
                _settingThirdFps.text = "High / 768p";
                _settingFourthFps.text = "Ultra / 1080p";
                _settingFifthFps.text = "Ultra / 1440p";
                _settingSixthFps.text = "";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "220-235";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "196-203";
                    secondFps.color = _greenColor;
                    thirdFps.text = "154-160";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "98-105";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "75-80";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fisrtFps.text = "160-170";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "140-150";
                    secondFps.color = _greenColor;
                    thirdFps.text = "110−120";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "70−75";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "55-63";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2060")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "High / 1080p";
                _settingThirdFps.text = "Ultra / 1080p";
                _settingFourthFps.text = "Ultra / 1440p";
                _settingFifthFps.text = "Ultra / 4k";
                _settingSixthFps.text = "Ultra / 5k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "115-120";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "100-110";
                    secondFps.color = _greenColor;
                    thirdFps.text = "90-95";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "75-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "60-65";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "45-55";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fisrtFps.text = "90-105";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "80-90";
                    secondFps.color = _greenColor;
                    thirdFps.text = "70-75";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "60-64";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "48-53";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "37-40";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2060s")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "130-135";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "105-110";
                    secondFps.color = _greenColor;
                    thirdFps.text = "85-90";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "72-80";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "57-65";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "45-55";
                    sixthFps.color = _lightGreenColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "100-110";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "80-87";
                    secondFps.color = _greenColor;
                    thirdFps.text = "67-72";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "55-60";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "45-53";
                    fifthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "35-40";
                    sixthFps.color = _orangeColor;
                }
            }
            if (nameVideocard == "RGX 2070")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "150-160";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "117-125";
                    secondFps.color = _greenColor;
                    thirdFps.text = "104-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "83-96";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "70-80";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "58-67";
                    sixthFps.color = _greenColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "120-130";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "90-97";
                    secondFps.color = _greenColor;
                    thirdFps.text = "80-90";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "65-80";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "55-63";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "45-55";
                    sixthFps.color = _lightGreenColor;
                }
            }
            if (nameVideocard == "RGX 2070s")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "180-190";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "120-130"; 
                    secondFps.color = _greenColor;
                    thirdFps.text = "112-120";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "90-97";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "77-85"; //в 4к
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "68-75";
                    sixthFps.color = _greenColor;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "140-145";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "95-105";
                    secondFps.color = _greenColor;
                    thirdFps.text = "90-95";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "75-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "65-72";
                    fifthFps.color = _greenColor;
                    sixthFps.enabled = true;
                    sixthFps.text = "53-67";
                    sixthFps.color = _greenColor;
                }
            }
            if (nameVideocard == "RGX 2080 TI")
            {
                _settingFisrtFps.text = "Average / 1080p";
                _settingSecondFps.text = "Ultra / 1080p";
                _settingThirdFps.text = "Ultra / 1440p";
                _settingFourthFps.text = "Ultra / 4k";
                _settingFifthFps.text = "Ultra / 5k";
                _settingSixthFps.text = "Ultra / 8k";

                if (_checkBoolActiveSli == true)
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "220-230";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "190-200";
                    secondFps.color = _greenColor;
                    thirdFps.text = "165-180";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "140-150";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "104-110"; //в 4к
                    fifthFps.color = _greenColor;
                    sixthFps.text = "78-92";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fifthFps.enabled = true;
                    fisrtFps.text = "170-195";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "150-170";
                    secondFps.color = _greenColor;
                    thirdFps.text = "130-140";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "110-115";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "80-90"; //в 4к
                    fifthFps.color = _greenColor;
                    sixthFps.text = "60-75";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3070")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "234-243";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "170-185";
                    secondFps.color = _greenColor;
                    thirdFps.text = "143-150";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "105-120";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "78-90";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "23-29";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "180-200";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "130-140";
                    secondFps.color = _greenColor;
                    thirdFps.text = "110-115";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "80-90";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "60-75";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "15-20";
                    sixthFps.color = _redColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3070s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "273-290";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "195-210";
                    secondFps.color = _greenColor;
                    thirdFps.text = "165-190";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "135-150";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "115-130";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "30-37";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "210-220";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "150-165";
                    secondFps.color = _greenColor;
                    thirdFps.text = "127-140";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "105-110";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "90-100";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "21-27";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3080")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "245-270";
                    secondFps.color = _greenColor;
                    thirdFps.text = "225-240";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "160-193";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "145-155";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "44-56";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "250-260";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "190-210";
                    secondFps.color = _greenColor;
                    thirdFps.text = "167-186";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "125-140";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "110-120";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "34-45";
                    sixthFps.color = _orangeColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3080s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "280-299";
                    secondFps.color = _greenColor;
                    thirdFps.text = "253-265";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "200-220";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "170-185";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "60-72";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "230-240";
                    secondFps.color = _greenColor;
                    thirdFps.text = "195-210";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "155-170";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "132-140";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "43-50";
                    sixthFps.color = _lightGreenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3090")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "300+";
                    secondFps.color = _greenColor;
                    thirdFps.text = "300+";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "240-260";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "195-210";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "120-137";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "276-290";
                    secondFps.color = _greenColor;
                    thirdFps.text = "234-250";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "186-200";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "150-160";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "64-73";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
            }
            if (nameVideocard == "RGX 3090s")
            {
                _settingFisrtFps.text = "Average / 1440p";
                _settingSecondFps.text = "Ultra / 1440p";
                _settingThirdFps.text = "Ultra / 4k";
                _settingFourthFps.text = "Ultra / 5k";
                _settingFifthFps.text = "Ultra / 8k";
                _settingSixthFps.text = "Ultra / 10k";

                if (_checkBoolActiveSli == true)
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "300+";
                    secondFps.color = _greenColor;
                    thirdFps.text = "300+";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "286-298";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "234-250";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "100-110";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
                else
                {
                    fisrtFps.text = "300+";
                    fisrtFps.color = _greenColor;
                    secondFps.text = "300+";
                    secondFps.color = _greenColor;
                    thirdFps.text = "280-290";
                    thirdFps.color = _greenColor;
                    fourthFos.text = "220-230";
                    fourthFos.color = _greenColor;
                    fifthFps.text = "180-200";
                    fifthFps.color = _greenColor;
                    sixthFps.text = "76-90";
                    sixthFps.color = _greenColor;
                    sixthFps.enabled = true;
                }
            }
        }
    }
}
