using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class CheckQuestScript : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private UpgradeTreeData _upgradeTreeData;
    [SerializeField] private FunctionPanelButton _functionPanelButton;

    [Header("Все тексты")]
    [SerializeField] private Text _textConditionsMoneyQuest;
    [SerializeField] private Text _textConditionsFunQuest;

    void Start() { StartCoroutine(CheckQuest()); }
    
    public IEnumerator CheckQuest()
    {
        while (true)
        {
            if (_mainGameMechanics.Money >= _upgradeTreeData.RewardQuest)
            {
                _upgradeTreeData.Conditions *= 2;
                _upgradeTreeData.TextConditions = "Накопить $" + _upgradeTreeData.Conditions.ToString();
                _textConditionsMoneyQuest.text = _upgradeTreeData.TextConditions;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
