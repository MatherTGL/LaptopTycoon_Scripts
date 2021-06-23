using UnityEngine;

public class MoneyPanel : MonoBehaviour
{

    [SerializeField] private GameObject _DopMoneyPanel; //Открывается еще одна панель при нажатии на деньги игрока
    void Start()
    {
        _DopMoneyPanel.SetActive(false);
    }    

    public void PlayerMoneyButton() //Там где выведены деньги игрока
    {
        _DopMoneyPanel.SetActive(!_DopMoneyPanel.activeSelf);
    }
}
