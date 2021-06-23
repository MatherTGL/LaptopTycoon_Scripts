using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TogglesDLCCompany : MonoBehaviour
{
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    [SerializeField] private byte _saveToggle;
    [SerializeField] private Toggle _toggleComp;
    [SerializeField] private string _nameToggle;
    [SerializeField] private int _costDLC;

    void Awake()
    {
        _toggleComp = GetComponent<Toggle>();

        if (_nameToggle == "1")
        {
            if (PlayerPrefs.HasKey("saveToggleDLCFirst"))
            {
                _saveToggle = (byte)PlayerPrefs.GetInt("saveToggleDLCFirst");
                if (_saveToggle == 1) { _toggleComp.isOn = true; }                   
                else { _toggleComp.isOn = false; }                
            }
                
        }
        if (_nameToggle == "2")
        {
            if (PlayerPrefs.HasKey("saveToggleDLCSecond"))
            {
                _saveToggle = (byte)PlayerPrefs.GetInt("saveToggleDLCSecond");
                if (_saveToggle == 1) { _toggleComp.isOn = true; }                   
                else { _toggleComp.isOn = false; }           
            }     
        }
        if (_nameToggle == "3")
        {
            if (PlayerPrefs.HasKey("saveToggleDLCThird"))
            {
                _saveToggle = (byte)PlayerPrefs.GetInt("saveToggleDLCThird");
                if (_saveToggle == 1) { _toggleComp.isOn = true; }                   
                else { _toggleComp.isOn = false; }                
            }      
        }
        StartCoroutine(checkSavingToggleDLC());
    }

    IEnumerator checkSavingToggleDLC()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            if (_toggleComp.isOn == true) { _saveToggle = 1; _mainGameMechanics.Money -= _costDLC; }
            else { _saveToggle = 0; }
           
            if (_nameToggle == "1") { PlayerPrefs.SetInt("saveToggleDLCFirst", _saveToggle); }
            else if (_nameToggle == "2") { PlayerPrefs.SetInt("saveToggleDLCSecond", _saveToggle); }            
            else { PlayerPrefs.SetInt("saveToggleDLCThird", _saveToggle); }
    
            yield return new WaitForSeconds(4);
        }       
    }
}
