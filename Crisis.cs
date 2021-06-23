using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crisis : MonoBehaviour
{
    [Header("Доступ к другим скриптам")]
    [SerializeField] private GameData _gameData;
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    [Header("Активирован ли кризис")]
    public bool ActiveCrisis;
    public int TimeCrisis;

    [Header("Цвет текста кризис")]
    [SerializeField] private Color _crisisTextColor;
    [SerializeField] private Color _defaultTextColor;

    void Start()
    {
        ActiveCrisis = false;
        TimeCrisis = Random.Range(200000, 700000);
    }

    void Update()
    {
        ActiveCrisisMethod();
    }

    void ActiveCrisisMethod()
    {
        if (ActiveCrisis == true)
        {
            StartCoroutine(TimeCrisisCoroutine());
            _mainGameMechanics.MinMoneyRandom = 1650000;
            _mainGameMechanics.MaxMoneyRandom = 2600000;
            _gameData.TextDay.color = _crisisTextColor;
            _gameData.TextMonth.color = _crisisTextColor;
            _gameData.TextYear.color = _crisisTextColor;
        }
        else
        {
            StopCoroutine(TimeCrisisCoroutine());
            _mainGameMechanics.MinMoneyRandom = 400000;
            _mainGameMechanics.MaxMoneyRandom = 600000;
            TimeCrisis = Random.Range(200000, 700000);
            _gameData.TextDay.color = _defaultTextColor;
            _gameData.TextMonth.color = _defaultTextColor;
            _gameData.TextYear.color = _defaultTextColor;
        }
    }

    IEnumerator TimeCrisisCoroutine()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(1);
            TimeCrisis -= 1;
            if (TimeCrisis <= 0)
            {
                ActiveCrisis = false;        
                yield break;
            }
            yield return new WaitForSecondsRealtime(1);
        }
    }
}
