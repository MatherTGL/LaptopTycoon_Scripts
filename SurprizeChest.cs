using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SurprizeChest : MonoBehaviour
{
    [Header("Доступ к другим скриптам")]
    [SerializeField] private CheckTime _checkTime;
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    public byte RandomDrop;
    public Button SurpizeBoxObject;
    public Image ChestImage;
    public Slider ChestTimeImage;
    public Image ChestTwoImage;
    public Image fakeImageDisabledChest;
    public GameObject SurprizePanel;
    public Color ChestColorImage;
    public double WhatPrize; //Что и сколько выйграл игрок
    public Text TextWhatPrize;

    [Header("Цвета для призов")]
    public Color _moneyColorPrize;
    [SerializeField] private Color _funColorPrize;
    [SerializeField] private Color _recearchPointColorPrize;

    void Start() { StartCoroutine(CheckNumberSurprize()); }
    public void OkeySurprizeButton() { SurprizePanel.SetActive(false); WhatPrize = 0; }
    IEnumerator CheckNumberSurprize()
    {
        while(true)
        {
            if (RandomDrop == 1)
            {               
                if (_mainGameMechanics.Money < 10000000000) { WhatPrize = _mainGameMechanics.Money * UnityEngine.Random.Range(0.5f, 1f); }
                if (_mainGameMechanics.Money >= 10000000000) { WhatPrize = _mainGameMechanics.Money * UnityEngine.Random.Range(0.05f, 0.2f); }
                if (_mainGameMechanics.Money >= 50000000000) { WhatPrize = _mainGameMechanics.Money * UnityEngine.Random.Range(0.05f, 0.15f); }
                if (_mainGameMechanics.Money >= 100000000000) { WhatPrize = _mainGameMechanics.Money * UnityEngine.Random.Range(0.05f, 0.1f); }

                TextWhatPrize.text = "+$" + Mathf.Round((float)WhatPrize).ToString("#,#");
                _mainGameMechanics.Money += WhatPrize;
                TextWhatPrize.color = _moneyColorPrize;
                RandomDrop = 0;
            }
            if (RandomDrop == 2)
            {
                WhatPrize = _mainGameMechanics.Fun * UnityEngine.Random.Range(500, 0.4f);
                TextWhatPrize.text = "+" + Mathf.Round((float)WhatPrize).ToString("#.#") + " Fan";
                _mainGameMechanics.Fun += Mathf.Round((float)WhatPrize);
                TextWhatPrize.color = _funColorPrize;
                RandomDrop = 0;
            }
            if (RandomDrop == 3)
            {
                WhatPrize = UnityEngine.Random.Range(70, 100);
                _mainGameMechanics.RecearchPoint += (ushort)WhatPrize;
                TextWhatPrize.text = "+ " + Mathf.Round((float)WhatPrize).ToString("#.#") + " RP";
                TextWhatPrize.color = _recearchPointColorPrize;
                RandomDrop = 0;
            }           
            yield return new WaitForSeconds(_checkTime.CoroutineTime);
        }
    }
}
