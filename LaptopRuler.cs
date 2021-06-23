using UnityEngine;
using UnityEngine.UI;

public class LaptopRuler : MonoBehaviour
{
    [SerializeField] private Toggle[] _rulerLaptop;

    private void OnEnable()
    {
        _rulerLaptop[0].isOn = true;
        _rulerLaptop[1].isOn = false;
        _rulerLaptop[2].isOn = false;
    }


    public void toggleRulerB()
    {
        _rulerLaptop[0].isOn = true;
        _rulerLaptop[1].isOn = false;
        _rulerLaptop[2].isOn = false;
    }

    public void toggleRulerM()
    {
        _rulerLaptop[0].isOn = false;
        _rulerLaptop[1].isOn = true;
        _rulerLaptop[2].isOn = false;
    }

    public void toggleRulerF()
    {
        _rulerLaptop[0].isOn = false;
        _rulerLaptop[1].isOn = false;
        _rulerLaptop[2].isOn = true;
    }
}
