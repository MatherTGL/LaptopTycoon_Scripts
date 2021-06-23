using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OSNamePlayerEdit : MonoBehaviour
{
    [SerializeField] private OpenOS _openOS;
    [Header("Текст InputField")]
    public GameObject InputOSNamePlayer;
    [Header("Булевая названия компании")]
    public bool ActiveNameOSPanel;

    void Start()
    {
        StartCoroutine(ActiveNameOSPanelCoroutine());
        if (PlayerPrefs.HasKey("OSNamePlayer"))
        {
            _openOS.namePlayerOS = PlayerPrefs.GetString("OSNamePlayer");
            ActiveNameOSPanel = false;
        }
    }

    public void ValueChanged() { _openOS.namePlayerOS = "TGL "; }

    public void EndEdit()
    {
        _openOS.namePlayerOS = InputOSNamePlayer.GetComponent<Text>().text;
        ActiveNameOSPanel = false;
        PlayerPrefs.SetString("OSNamePlayer", _openOS.namePlayerOS);
    }

    IEnumerator ActiveNameOSPanelCoroutine()
    {
        while (true)
        {
            if (_openOS.closeNameOSPanel == 1) { _openOS._checkNameOSPanel.SetActive(false); }
            else { _openOS._checkNameOSPanel.SetActive(true); }
            yield return new WaitForSeconds(310);
        }
    }
}
