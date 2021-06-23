using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Laboratory : MonoBehaviour
{
    [Header("Доступ к скриптам")]
    private UpgradeTree _upgradeTree;
    [SerializeField] private BuyLabUpgrade _buyLabUpgrade;
    [SerializeField] private MainGameMechanics _mainGameMechanics;

    [Header("Доходы лабы")]
    public byte IncomeLaboratoryRP; //Доход RP с лаборатории
    public Text TextIncomeLaboratory; //Текст доходов 
    [Header("Расходы на лабу")]
    public uint ExpenditureLaboratory; //Расходы на лабораторию
    public Text TextExpenditureLaboratory; //Текст доходов 
    [Header("После покупки лабы")]
    public GameObject _InfoLab;
    public GameObject _BuyLab;
    [Header("Переменная домножения")]
    public ushort multiplicationExpenditureLab;

    private void Awake()
    {
        StartCoroutine(checkLab());
    }

    private IEnumerator checkLab()
    {
        while (true)
        {
            if (_buyLabUpgrade.saveLabBuy == 1)
            {
                _mainGameMechanics.Money -= ExpenditureLaboratory;
                _mainGameMechanics.RecearchPoint += 1;
            }
            yield return new WaitForSeconds(10);
        }
    }
}
