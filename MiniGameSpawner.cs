using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSpawner : MonoBehaviour
{
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private MiniGameCreating _miniGameCreating;

    private Vector2 _randomVector;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(_randomVector * Time.deltaTime);
    }

    public void clickMiniGameButton()
    {
        _createLaptop.PercentCreateLaptop += Random.Range(2, 4);
        _randomVector = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        Instantiate(_miniGameCreating.buttonClickPrefab, _miniGameCreating.SpawnerZone.transform);
    }
}
