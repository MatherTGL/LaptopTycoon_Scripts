using UnityEngine;
using UnityEngine.UI;

public class SettingGame : MonoBehaviour
{
    [Header("Выключить звук")]
    public Toggle ActiveSound; //Включить/выключить звук
    [Header("Включить читы")]
    public Toggle ActiveCheats;

    public GameObject AudioSourceObject;
     
    void Awake() { ActiveSound.isOn = true; ActiveCheats.isOn = false; }
}
