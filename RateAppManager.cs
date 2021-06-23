using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateAppManager : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [Header("Панель рейтинга")]
    [SerializeField] private GameObject _ratePanel;
    [SerializeField] private bool _activeRatePanel; //Разрешено ли активировать панель
    [SerializeField] private bool _laterActiveRatePanel;


    void Start()
    {
        StartCoroutine(checkActiveRatePanel());
        _ratePanel.SetActive(false);
    }

    public void laterRatePanel()
    {
        _ratePanel.SetActive(false);
        _laterActiveRatePanel = true;
        Time.timeScale = 1;
    }

    public void deactiveRatePanel()
    {
        _activeRatePanel = false;
        _ratePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void okeyRatePanel()
    {
        _ratePanel.SetActive(false);
        _activeRatePanel = false;
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.TGL.LaptopTycoon");
        Time.timeScale = 1;
    }

    IEnumerator checkActiveRatePanel()
    {
        while(true)
        {
            if (_activeRatePanel == true)
            {
                if (_createLaptop.ownLaptopCompany == 3)
                {
                    if (_functionPanelButton._MenuPanel)
                    {
                        if (!_functionPanelButton.CreateLaptopPanel.activeSelf)
                        {
                            if (_laterActiveRatePanel != true)
                            {
                                yield return new WaitForSecondsRealtime(2);
                                _ratePanel.SetActive(true);
                                Time.timeScale = 0;
                            }
                        }                    
                    }
                }

                if (_createLaptop.ownLaptopCompany == 5)
                {
                    _laterActiveRatePanel = false;
                    if (_functionPanelButton._MenuPanel)
                    {
                        if (!_functionPanelButton.CreateLaptopPanel.activeSelf)
                        {    
                            if (_laterActiveRatePanel != true)
                            {
                                yield return new WaitForSecondsRealtime(2);
                                _ratePanel.SetActive(true);
                                _laterActiveRatePanel = true;
                                Time.timeScale = 0;
                            }
                        }
                    }
                }
                if (_createLaptop.ownLaptopCompany == 10)
                {
                    _laterActiveRatePanel = false;
                    if (_functionPanelButton._MenuPanel)
                    {
                        if (!_functionPanelButton.CreateLaptopPanel.activeSelf)
                        {
                            if (_laterActiveRatePanel != true)
                            {
                                yield return new WaitForSecondsRealtime(2);
                                _ratePanel.SetActive(true);
                                _laterActiveRatePanel = true;
                                Time.timeScale = 0;
                            }
                        }
                    }
                }
            }
            yield return new WaitForSecondsRealtime(3);
        }
    }
}
