using UnityEngine;
using UnityEngine.SceneManagement;

public class Antihacksystem : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private FunctionPanelButton _functionPanelButton;

    private void OnEnable()
    {
        if (_gameData.Year <= 2020)
        {
            if (_mainGameMechanics.Money >= 3000000000000)
            {
                if (_mainGameMechanics.RecearchPoint >= 9000)
                {
                    SceneManager.LoadScene(0);
                    PlayerPrefs.DeleteAll();
                    _mainGameMechanics.Money = 1000000000;
                    _mainGameMechanics._gameoverPanel.SetActive(false);
                    _functionPanelButton.MainPanel.SetActive(true);
                    _functionPanelButton._MenuPanel.SetActive(false);
                    _functionPanelButton._MenuPanelButtons.SetActive(true);
                    _functionPanelButton.textLaptopTycoon.SetActive(true);
                    _functionPanelButton.ButtonQuitMenu.SetActive(true);
                    _functionPanelButton.ButtonSettingMenu.SetActive(true);
                    _functionPanelButton.ButtonStartMenu.SetActive(true);
                    _gameData.Day = 10;
                    _gameData.Month = 1;
                    _gameData.Year = 2019;
                    _mainGameMechanics.RecearchPoint = 20;
                    _mainGameMechanics.Fun = 16;
                }
            }
        }
    }
}
