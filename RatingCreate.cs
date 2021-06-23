using UnityEngine;
using UnityEngine.UI;

public class RatingCreate : MonoBehaviour
{  
    //Доступ к разным скриптам
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private FunctionPanelButton _functionPanelButton;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private RatingGenerateText _ratingGenerateText;
    [SerializeField] private Crisis _crisis;

    public float AverageRating; //Средний рейтинг
    [SerializeField] private Text _textAverageRating;
    public string averageFormate = "#.##";

    [Header("Алгоритм прибыли")]
    public double AlgorithmMoneyPlus; //Эта переменная принимает _Rating / 10
    public int AlgorithmFunPlus; //Эта переменная принимает _Rating / 15

    private void Update() { _textAverageRating.text = AverageRating.ToString(averageFormate); }

    public void RatingButtonPanelFinish() //Кнопка для продолжения после просмотра рейтингов
    {
        checkRatingPlusMoney();
        _createLaptop._ratingPanelCreateLaptop.SetActive(false);
        _functionPanelButton._MenuPanel.SetActive(false);
        _createLaptop.gamesTestLaptopPanel.SetActive(true);
    }

    public void testGamesLaptop()
    {
        _createLaptop.gamesTestLaptopPanel.SetActive(false);
        _createLaptop.newsLaptopPanel.SetActive(true);
        AverageRating = 0;
        AlgorithmMoneyPlus = 0;
        AlgorithmFunPlus = 0;
        _createLaptop.scoreRatingAverage = 200;
        _functionPanelButton._allOffices.SetActive(true);
        _mainGameMechanics.textCostOption.text = "$ " + _mainGameMechanics.fullCostLaptop;
        _createLaptop.makeLaptopPanel.SetActive(false);
    }

    public void newsPanelButton()
    {
        _functionPanelButton._MenuPanel.SetActive(true);
        _createLaptop.newsLaptopPanel.SetActive(false);
        PlayerPrefs.SetInt("ownLaptopCompany", _createLaptop.ownLaptopCompany);
        _mainGameMechanics.fullCostLaptop = 365;
        _mainGameMechanics.FullZeroCostLaptop = 365;       
    }

    private void checkRatingPlusMoney()
    {
        if (_createLaptop._Rating == 1)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 5f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 10);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 3f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 8);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 2)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 7f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 11);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 5f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 10);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 3)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 8.3f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 13.8f);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 5.80f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 11.3f);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 4)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 9.36f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 14.4f);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 6.2f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 12.1f);
                _mainGameMechanics.Money -= AlgorithmMoneyPlus;
                _mainGameMechanics.Fun -= AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 5)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 18.4f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 14.4f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 22.2f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 17.8f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 6)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 17.34f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 14f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 20.8f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 18.8f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 7)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 16.54f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 13.44f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 19.3f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 18.3f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 8)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 15.75f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 12.35f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 18.75f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 17.8f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 9)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 15f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 11.88f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 18.9f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 16.4f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
        }
        if (_createLaptop._Rating == 10)
        {
            if (_crisis.ActiveCrisis != true)
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 13.8f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 10.48f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
            else
            {
                AlgorithmMoneyPlus = (double)(_mainGameMechanics.Money * AverageRating / 18f);
                AlgorithmFunPlus = (int)(_mainGameMechanics.Fun * AverageRating / 15.3f);
                _mainGameMechanics.Money += AlgorithmMoneyPlus;
                _mainGameMechanics.Fun += AlgorithmFunPlus;
            }
        }
    }
}
