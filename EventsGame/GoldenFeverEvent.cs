using System.Collections;
using UnityEngine;

public class GoldenFeverEvent : MonoBehaviour
{
    [Header("Доступы к скриптам")]
    [SerializeField] private GameData _gameData;
    private BuyCompany _buyCompany;
    [SerializeField] private MainGameMechanics _mainGameMechanics;



    [SerializeField] private int _lastsRush; //Сколько длится лихорадка
    [SerializeField] private bool _boolLastsRush = false; //Есть ли щас лихорадка

    [SerializeField] private double _incomeOwnCompany;

    void Start()
    {
        StartCoroutine(startGoldRush());
        _lastsRush = Random.Range(30, 340); 
    }

   IEnumerator startGoldRush()
    {
        while(true)
        {
            if (_gameData.Year == Random.Range(2020, 2022))
            {
                if (_gameData.Month == Random.Range(1, 12))
                {
                    if (_gameData.Day == Random.Range(1, 20))
                    {
                        _boolLastsRush = true;
                        if (_boolLastsRush == true)
                        {
                            _lastsRush--;
                            _incomeOwnCompany = _mainGameMechanics._IncomeCumulative * 3;
                            _mainGameMechanics.Money += _mainGameMechanics._IncomeCumulative;
                            Debug.Log("Gold Rush Start");
                        }
                    }
                }
            }
            if (_lastsRush <= 0)
            {
                _boolLastsRush = false;
                _incomeOwnCompany = 0;
                Debug.Log("Gold Rush Finish");
            }
            yield return new WaitForSeconds(1);
        }
    }
}
