using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompanyNameInputField : MonoBehaviour
{
    [Header("Доступ к главному скрипту")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [Header("Название компании String")]
    public string NameCompany;
    [Header("Текст InputField")]
    public GameObject InputFirldNameCompany;
    [Header("Булевая названия компании")]
    public bool ActiveNameCompanyPanel = true;

    private void Start()
    {
        StartCoroutine(ActiveNameCompanyPanelCoroutine());
        NameCompany = "TGL ";
        _mainGameMechanics._TextNameCompany.text = NameCompany + " Company";
    }
    public void ValueChanged()
    {
        if (NameCompany != "")
        {
            NameCompany = InputFirldNameCompany.GetComponent<Text>().text;
            _mainGameMechanics._TextNameCompany.text = NameCompany + " Company";
            ActiveNameCompanyPanel = false;
            PlayerPrefs.SetString("NameCompany", NameCompany);
        }
        else
        {
            NameCompany = "TGL ";
            _mainGameMechanics._TextNameCompany.text = NameCompany + " Company";
            ActiveNameCompanyPanel = false;
            PlayerPrefs.SetString("NameCompany", NameCompany);
        }
    }
    public void EndEdit()
    {
        if (NameCompany != "")
        {
            NameCompany = InputFirldNameCompany.GetComponent<Text>().text;
            _mainGameMechanics._TextNameCompany.text = NameCompany + " Company";
            ActiveNameCompanyPanel = false;
            PlayerPrefs.SetString("NameCompany", NameCompany);
        }
        else
        {
            NameCompany = "TGL ";
            _mainGameMechanics._TextNameCompany.text = NameCompany + " Company";
            ActiveNameCompanyPanel = false;
            PlayerPrefs.SetString("NameCompany", NameCompany);
        }
    }

    IEnumerator ActiveNameCompanyPanelCoroutine()
    {
        while(true)
        {
            if (ActiveNameCompanyPanel == false) { _functionPanelButton._NameCompanyPanel.SetActive(false); }
            else { _functionPanelButton._NameCompanyPanel.SetActive(true); }
            yield return new WaitForSeconds(310);
        }
    }
}
