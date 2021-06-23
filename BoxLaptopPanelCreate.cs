using UnityEngine;
using UnityEngine.UI;

public class BoxLaptopPanelCreate : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CostSliderSettings _costSliderSettings;
    public Toggle headphonesToggleLaptop;
    public Toggle caseToggleLaptop;
    [SerializeField] private string _nameToggleCheck;


    void Start()
    {
        headphonesToggleLaptop = GetComponent<Toggle>();
        caseToggleLaptop = GetComponent<Toggle>();
    }

    private void OnEnable()
    {
        headphonesToggleLaptop.isOn = false;
        caseToggleLaptop.isOn = false;
    }

    public void checkTogglesButton()
    {
        if (_nameToggleCheck == "Headphones")
        {
            if (headphonesToggleLaptop.isOn == false)
            {
                _mainGameMechanics.FullZeroCostLaptop -= 20;
                _costSliderSettings.costSliderLaptop.maxValue -= 10;
            }
            if (headphonesToggleLaptop.isOn == true)
            {
                _mainGameMechanics.FullZeroCostLaptop += 20;
                _costSliderSettings.costSliderLaptop.maxValue += 10;
            }
        }

        if (_nameToggleCheck == "Case")
        {
            if (caseToggleLaptop.isOn == true)
            {
                _mainGameMechanics.FullZeroCostLaptop += 20;
                _costSliderSettings.costSliderLaptop.maxValue += 10;
            }
            if (caseToggleLaptop.isOn == false)
            {
                _mainGameMechanics.FullZeroCostLaptop -= 20;
                _costSliderSettings.costSliderLaptop.maxValue -= 10;
            }
        }
    }
}
