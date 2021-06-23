using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class newsLaptop : MonoBehaviour
{
    [SerializeField] private CompanyNameInputField _companyName;
    [SerializeField] private Crisis _crisis;
    [SerializeField] private OpenOS _openOS;
    [SerializeField] private MainGameMechanics _mainGameMechanics;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private LocalizationManager _localizationManager;

    [SerializeField] private byte _randomNews;
    [SerializeField] private string _newsString;
    [SerializeField] private string _effectNewsLaptop;
    [SerializeField] private Text _textEffectNewsLaptop;
    [SerializeField] private Text _textNewsString;

    [SerializeField] private bool _checkCrisisNews;
    [SerializeField] private bool _williamLapkinNews;
    [SerializeField] private bool _starPopSceneNews;
    [SerializeField] private bool _hackOSPlayer;
    [SerializeField] private bool _mamMoneyNews;
    [SerializeField] private bool _creditNews;
    [SerializeField] private bool _technoblogersNews; //Техноблогеры стали делать чаще обзоры 
    [SerializeField] private bool _animalNews;
    [SerializeField] private bool _fakeNews;
    [SerializeField] private bool _faceIDNews;

    [SerializeField] private byte _byteCheckCrisisNews;
    [SerializeField] private byte _byteWilliamLapkinNews;
    [SerializeField] private byte _byteStarPopSceneNews;
    [SerializeField] private byte _byteHackOSPlayer;
    [SerializeField] private byte _byteMamMoneyNews;
    [SerializeField] private byte _byteCreditNews;
    [SerializeField] private byte _byteTechnoblogersNews;
    [SerializeField] private byte _byteAnimalNews;
    [SerializeField] private byte _byteFakeNews;
    [SerializeField] private byte _byteFaceIDNews;

    void Start()
    {
        _byteWilliamLapkinNews = (byte)PlayerPrefs.GetInt("WilliamLapkinNews");
        _byteCheckCrisisNews = (byte)PlayerPrefs.GetInt("crisisNews");
        _byteStarPopSceneNews = (byte)PlayerPrefs.GetInt("starPopSceneNews");
        _byteHackOSPlayer = (byte)PlayerPrefs.GetInt("hackOSNews");
        _byteMamMoneyNews = (byte)PlayerPrefs.GetInt("mamMoneyNews");
        _byteCreditNews = (byte)PlayerPrefs.GetInt("creditNews");
        _byteTechnoblogersNews = (byte)PlayerPrefs.GetInt("blogersNews");
        _byteAnimalNews = (byte)PlayerPrefs.GetInt("animalNews");
        _byteFakeNews = (byte)PlayerPrefs.GetInt("FakeNews");
        _byteFaceIDNews = (byte)PlayerPrefs.GetInt("faceIDNews");
    }

    private void OnEnable()
    {
        _randomNews = (byte)Random.Range(1, 12);
        if (_randomNews == 1)
        {
            if (_williamLapkinNews != true) { StartCoroutine(checkEffectNeWS()); }
            else { _randomNews = (byte)Random.Range(1, 12); }
        }
           
        else if (_randomNews == 3)
        {
            if (_crisis.ActiveCrisis == true) { StartCoroutine(checkEffectNeWS()); }
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if (_randomNews == 4)
        {
            if (_starPopSceneNews != true) { StartCoroutine(checkEffectNeWS()); }
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if (_randomNews == 5)
        {
            if (_openOS._activeOSUpgrade == 1) { if (_hackOSPlayer != true) { StartCoroutine(checkEffectNeWS()); } }
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if(_randomNews == 6)
        {
            if (_mamMoneyNews != true) { StartCoroutine(checkEffectNeWS()); }                
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if (_randomNews == 7)
        {
            if (_creditNews != true) { Debug.Log("credit"); }
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if (_randomNews == 8)
        {
            if (_technoblogersNews != true) { StartCoroutine(checkEffectNeWS()); }               
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if (_randomNews == 9)
        {
            if (_animalNews != true) { StartCoroutine(checkEffectNeWS()); }               
            else { _randomNews = (byte)Random.Range(1, 12); }
        }

        else if (_randomNews == 10)
        {
            if (_fakeNews != true) { StartCoroutine(checkEffectNeWS()); }
            else { _randomNews = (byte)Random.Range(1, 12); }
        }
            
        else
        {
            if (_faceIDNews != true) { StartCoroutine(checkEffectNeWS()); }                
            else { _randomNews = (byte)Random.Range(1, 12); }
        }
    }

    void Update() { _textEffectNewsLaptop.text = _effectNewsLaptop; _textNewsString.text = _newsString; }

    IEnumerator checkEffectNeWS()
    {
        while (true)
        {
            if (_randomNews == 1)
            {
                if (_williamLapkinNews != true)
                {
                    _effectNewsLaptop = "- $50 000 000";
                    _byteWilliamLapkinNews = 1;
                    _williamLapkinNews = true;
                    PlayerPrefs.SetInt("WilliamLapkinNews", _byteWilliamLapkinNews);
                     _mainGameMechanics.Money -= 50000000; 
                    if (_localizationManager._indexLanguage == 1)
                        _newsString = "William Lapkin said he will sue the company " + _companyName.NameCompany + " for the fact that their laptops do not hide browser history";
                    else
                        _newsString = "Уильям Лапкин заявил, что подаст в суд на компанию " + _companyName.NameCompany + "за то, что их ноутбуки не скрывают историю браузера.";
                    yield break;
                }
            }

            if (_randomNews == 2)
            {
                if (_localizationManager._indexLanguage == 1) { _newsString = "I was offended if it was called differently"; }
                else { _newsString = "Я бы обиделся, если это называлось по-другому."; }
                _effectNewsLaptop = "no effects";
                yield break;
            }

            if (_randomNews == 3)
            {
                if (_crisis.ActiveCrisis == true)
                {
                    if (_checkCrisisNews != true)
                    {
                        _checkCrisisNews = true;
                        _effectNewsLaptop = "-33% off money";
                        _byteCheckCrisisNews = 1;
                        PlayerPrefs.SetInt("crisisNews", _byteCheckCrisisNews);                        
                        _mainGameMechanics.Money -= _mainGameMechanics.Money * 0.33f; 
                        if (_localizationManager._indexLanguage == 1)
                            _newsString = "Due to the uneven distribution of gummy bears, a global gummy crisis occurred around the world, which reduced the market by 33%";
                        else
                            _newsString = "Из-за неравномерного распределения мармеладных мишек, во всем мире произошел глобальный мармеладный кризис, который сократил рынок на 33%.";
                        yield break;
                    }
                }
                else { _randomNews = (byte)Random.Range(1, 12); }
            }

            if (_randomNews == 4)
            {
                if (_starPopSceneNews != true)
                {
                    _effectNewsLaptop = "+ $800 000 000 / + 10 000 Fans";
                    _starPopSceneNews = true;
                    _byteStarPopSceneNews = 1;
                    PlayerPrefs.SetInt("starPopSceneNews", _byteStarPopSceneNews);
                    _mainGameMechanics.Money += 800000000; _mainGameMechanics.Fun += 10000; 
                    if (_localizationManager._indexLanguage == 1) { _newsString = "Pop stars declare they love the company's products " + _companyName.NameCompany; }
                    else { _newsString = "Звезды эстрады заявляют о любви к продукции компании " + _companyName.NameCompany; }
                    yield break;
                }
            }

            if (_randomNews == 5)
            {
                if (_openOS._activeOSUpgrade == 1)
                {
                    if (_hackOSPlayer != true)
                    {
                        _effectNewsLaptop = "- $400 000 000";
                        _hackOSPlayer = true;
                        _byteHackOSPlayer = 1;
                        PlayerPrefs.SetInt("hackOSNews", _byteHackOSPlayer);                         
                        _mainGameMechanics.Money -= 400000000; 

                        if (_localizationManager._indexLanguage == 1) { _newsString = "Hacked " + _openOS.namePlayerOS + ". The data of many users was leaked"; }
                        else { _newsString = "Взломали " + _openOS.namePlayerOS + ". Произошла утечка данных многих пользователей."; }
                        yield break;
                    }
                }
                else { _randomNews = (byte)Random.Range(1, 12); }
            }

            if (_randomNews == 6)
            {
                if (_mamMoneyNews != true)
                {
                    _effectNewsLaptop = "+ $" + _mainGameMechanics.retailPrice;
                    _mamMoneyNews = true;
                    _byteMamMoneyNews = 1;
                    PlayerPrefs.SetInt("mamMoneyNews", _byteMamMoneyNews);
                    _mainGameMechanics.Money += _mainGameMechanics.retailPrice; 
                    if (_localizationManager._indexLanguage == 1) { _newsString = "On this laptop, I poured all my mom's money, and surprisingly, he pulls Tetris"; }
                    else { _newsString = "На этот ноут я слил все деньги мамы, и на удивление, тетрис он тянет!"; }
                    yield break;
                }
            }

            if (_randomNews == 7)
            {
                if (_creditNews != true)
                {
                    _creditNews = true;
                    _byteCreditNews = 1;
                    PlayerPrefs.SetInt("creditNews", _byteCreditNews);
                    if (_localizationManager._indexLanguage == 1)
                    {
                        _newsString = "Nice laptop. But no one will cancel the credit for reviewing me";
                        _effectNewsLaptop = "Credit canceled";
                    }
                    else
                    {
                        _newsString = "Хороший ноутбук. Но никто не отменит кредит за мой отзыв";
                        _effectNewsLaptop = "Кредит отменен!";
                    }
                    yield break;
                }
            }

            if (_randomNews == 8)
            {
                if (_technoblogersNews != true)
                {
                    _effectNewsLaptop = "+ 20% Fans";
                    _technoblogersNews = true;
                    _byteTechnoblogersNews = 1;
                    PlayerPrefs.SetInt("blogersNews", _byteTechnoblogersNews);
                    _mainGameMechanics.Fun += _mainGameMechanics.Fun * 0.20f; 
                    if (_localizationManager._indexLanguage == 1) { _newsString = "tech bloggers are increasingly reviewing " + _createLaptop.NameLaptop; }
                    else { _newsString = "технические блоггеры все чаще снимают обзоры на " + _createLaptop.NameLaptop; }
                    yield break;
                }
            }

            if (_randomNews == 9)
            {
                if (_animalNews != true)
                {
                    _effectNewsLaptop = "- $250 000 000";
                    _animalNews = true;
                    _byteAnimalNews = 1;
                    PlayerPrefs.SetInt("animalNews", _byteAnimalNews);
                    _mainGameMechanics.Money -= 250000000; 
                    if (_localizationManager._indexLanguage == 1)
                        _newsString = "Cats and kitties are offended! Animal rights ministry sues " + _companyName.NameCompany + "company for interfering with their laptops";
                    else
                    {
                        _newsString = "Кошки и котята обиделись! Министерство защиты прав животных подает в суд на " + _companyName.NameCompany + " company, за то, что их ноутбуки мешают проводить время с питомцами";
                    }
                    yield break;
                }
            }

            if (_randomNews == 10)
            {
                if (_fakeNews != true)
                {
                    _effectNewsLaptop = "- 33% Fans";
                    _fakeNews = true;
                    _byteFakeNews = 1;
                    PlayerPrefs.SetInt("FakeNews", _byteFakeNews);
                    _mainGameMechanics.Fun -= _mainGameMechanics.Fun * 0.33f;
                    if (_localizationManager._indexLanguage == 1)
                        _newsString = "New fakes from aloExpress joined the market of equipment. Now they have learned to counterfeit and laptops " + _companyName.NameCompany;
                    else { _newsString = "На рынок оборудования пришли новые подделки от aloExpress. Теперь научились подделывать и ноутбуки " + _companyName.NameCompany; }
                    yield break;
                }
            }

            if (_randomNews == 11)
            {
                if (_faceIDNews != true)
                {
                    _effectNewsLaptop = "+ $400 000 000";
                    _faceIDNews = true;
                    _byteFaceIDNews = 1;
                    PlayerPrefs.SetInt("faceIDNews", _byteFaceIDNews);
                    _mainGameMechanics.Money += 400000000; 
                    if (_localizationManager._indexLanguage == 1) { _newsString = "It will be easier to follow users, as new generations of laptops will be equipped with Face ID"; }
                    else { _newsString = "За пользователями будет проще следить, ведь новые поколения ноутбуков будут оснащены Face ID."; }
                    yield break;
                }
            }
        }
    }
}
