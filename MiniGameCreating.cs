using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameCreating : MonoBehaviour
{
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private bool _checkActiveMiniGame;

    private Vector2 _randomVector;

    public GameObject SpawnerZone, buttonClickPrefab;

    void Start()
    {
        Instantiate(buttonClickPrefab, SpawnerZone.transform);
    }

    void Update()
    {
        if (_createLaptop.createInfoLaptopPanel.activeSelf) { _checkActiveMiniGame = true; }
        else { _checkActiveMiniGame = false; }        
    }
}
