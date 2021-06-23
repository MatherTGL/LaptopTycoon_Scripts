using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [Header("Доступ к другому скрипту")]
    [SerializeField] private FunctionPanelButton functionPanelButton;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;

    public bool activeTutorial;

    [SerializeField] private GameObject _buttonStaff;
    [SerializeField] private GameObject _buttonCreateLaptop;
    [SerializeField] private GameObject _arrowUpButton;

    [SerializeField] private Animation _upScrollButtonAnim;
    [SerializeField] private Animation _staffButtonAnim;
    [SerializeField] private Animation _createButtonAnim;

    [SerializeField] private Color _upArrowButtonColor;

    void Start()
    {
        if (!PlayerPrefs.HasKey("TutorialPanel")) { StartCoroutine(checkActivePanTutor()); }          
        else { _buttonStaff.SetActive(true); _buttonCreateLaptop.SetActive(true); }
    }

    public void checkActiveCreateButtonAnim()
    {
        _createButtonAnim.enabled = false;
        _upScrollButtonAnim.enabled = false;
        _arrowUpButton.GetComponent<RectTransform>().localScale = new Vector3(0.87586f, 0.87586f, 0.87586f);
        _arrowUpButton.GetComponent<Image>().color = _upArrowButtonColor;
    }

    IEnumerator checkActivePanTutor()
    {
        while(true)
        {
            if (activeTutorial == true)
            {
                _upScrollButtonAnim.Play();
                if (_mainGameMechanics.staffsPlayer != 0)
                {
                    _createButtonAnim.Play();
                    _staffButtonAnim.enabled = false;
                    if (_createLaptop.ownLaptopCompany != 0) { yield break; }
                }
                else { _staffButtonAnim.Play(); }
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
