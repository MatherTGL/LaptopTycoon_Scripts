using System.Collections;
using UnityEngine;
using System;

public class CheckTime : MonoBehaviour
{
    [Header("Доступ к другим скриптам")]
    [SerializeField] private SurprizeChest _surprizeChest;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [Header("Анимация ежедневного бонуса")]
    [SerializeField] private Animation ChestAnimation;
    public float CoroutineTime = 0.2f;
    
    void Awake()
    {
        CheckTimeOffline();
        StartCoroutine(AutosaveGame());
        _surprizeChest.SurprizePanel.SetActive(false);
        if (_surprizeChest.ChestImage.enabled == true) { _surprizeChest.fakeImageDisabledChest.enabled = false; }
        else { _surprizeChest.fakeImageDisabledChest.enabled = true; }
        if (!PlayerPrefs.HasKey("LastSession")) _surprizeChest.ChestTwoImage.enabled = false;
    }

    public void CheckTimeOffline()
    {
        TimeSpan timeSpan;
        if (PlayerPrefs.HasKey("LastSession"))
        {
            timeSpan = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            if (PlayerPrefs.HasKey("Autosave"))
            {
                _surprizeChest.ChestTimeImage.value = timeSpan.Hours;
                if (timeSpan.Hours >= 12 || timeSpan.Days >= 1)
                {
                    _surprizeChest.SurpizeBoxObject.enabled = true;
                    _surprizeChest.ChestImage.enabled = true;
                    _surprizeChest.ChestTwoImage.enabled = false;
                    _surprizeChest.ChestTimeImage.enabled = false;
                    _surprizeChest.fakeImageDisabledChest.enabled = false;
                }
                else
                {
                    _surprizeChest.SurpizeBoxObject.enabled = false;;
                    _surprizeChest.ChestImage.enabled = false;
                    _surprizeChest.ChestTwoImage.enabled = false;
                    _surprizeChest.fakeImageDisabledChest.enabled = true;
                    _surprizeChest.ChestTimeImage.enabled = true;
                    if (!_surprizeChest.SurprizePanel.activeSelf) { _surprizeChest.TextWhatPrize.text = ""; }                 
                }
            }          
        }     
    }

    public void OpenSurprizeBox()
    {
        if (_surprizeChest.SurpizeBoxObject.enabled == true)
        {
            _surprizeChest.RandomDrop = (byte)UnityEngine.Random.Range(1, 4);
            _surprizeChest.SurpizeBoxObject.enabled = false;
            _surprizeChest.SurprizePanel.SetActive(true);
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }      
    }

    IEnumerator AutosaveGame()
    {
        while(true)
        {
            PlayerPrefs.SetString("Autosave", DateTime.Now.ToString());
            CheckTimeOffline();           
            yield return new WaitForSeconds(CoroutineTime);
        }
    }
}
