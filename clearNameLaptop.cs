using UnityEngine;
using UnityEngine.UI;

public class clearNameLaptop : MonoBehaviour
{
    [SerializeField] private InputField _inputFieldNameText;
    [SerializeField] private CreateLaptop _createLaptop;
    [SerializeField] private byte _randomNameLaptop;
    [SerializeField] private byte _randomLetterLaptop;
    [SerializeField] private byte _randomNumberLaptop;

    void Awake()
    {
        _inputFieldNameText = GetComponent<InputField>();
    }

    void Update()
    {
        _createLaptop.NameLaptop = _inputFieldNameText.text;
    }

    void OnEnable()
    {
        _randomNameLaptop = (byte)Random.Range(1, 13);
        _randomLetterLaptop = (byte)Random.Range(1, 12);
        _randomNumberLaptop = (byte)Random.Range(1, 50);

        if (_randomNameLaptop == 1) 
        {
            _inputFieldNameText.text = "ASOS ";
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "ASOS " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "ASOS " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "ASOS " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "ASOS " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "ASOS " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "ASOS " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "ASOS " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "ASOS " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "ASOS " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "ASOS " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "ASOS " + "K" + _randomNumberLaptop; }
        }

        if (_randomNameLaptop == 2)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "AZER " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "AZER " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "AZER " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "AZER " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "AZER " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "AZER " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "AZER " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "AZER " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "AZER " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "AZER " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "AZER " + "K" + _randomNumberLaptop; }
        }

        if (_randomNameLaptop == 3)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Imoc " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Imoc " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Imoc " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Imoc " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Imoc " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Imoc " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Imoc " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Imoc " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Imoc " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Imoc " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Imoc " + "K" + _randomNumberLaptop; }
        }

        if (_randomNameLaptop == 4)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Samsa " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Samsa " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Samsa " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Samsa " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Samsa " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Samsa " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Samsa " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Samsa " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Samsa " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Samsa " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Samsa " + "K" + _randomNumberLaptop; }
        }

        if (_randomNameLaptop == 5)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "LJ " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "LJ " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "LJ " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "LJ " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "LJ " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "LJ " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "LJ " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "LJ " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "LJ " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "LJ " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "LJ " + "K" + _randomNumberLaptop; }
        }

        if (_randomNameLaptop == 6)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Sona " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Sona " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Sona " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Sona " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Sona " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Sona " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Sona " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Sona " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Sona " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Sona " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Sona " + "K" + _randomNumberLaptop; }
        }
        if (_randomNameLaptop == 7)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Delo " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Delo " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Delo " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Delo " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Delo " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Delo " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Delo " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Delo " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Delo " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Delo " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Delo " + "K" + _randomNumberLaptop; }
        }
        if (_randomNameLaptop == 8)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Toshnet " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Toshnet " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Toshnet " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Toshnet " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Toshnet " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Toshnet " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Toshnet " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Toshnet " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Toshnet " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Toshnet " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Toshnet " + "K" + _randomNumberLaptop; }
        }
        if (_randomNameLaptop == 9)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Panasos " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Panasos " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Panasos " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Panasos " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Panasos " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Panasos " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Panasos " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Panasos " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Panasos " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Panasos " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Panasos " + "K" + _randomNumberLaptop; }
        }
        if (_randomNameLaptop == 10)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "MSO " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "MSO " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "MSO " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "MSO " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "MSO " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "MSO " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "MSO " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "MSO " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "MSO " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "MSO " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "MSO " + "K" + _randomNumberLaptop; }
        }
        if (_randomNameLaptop == 11)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Lenava " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Lenava " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Lenava " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Lenava " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Lenava " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Lenava " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Lenava " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Lenava " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Lenava " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Lenava " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Lenava " + "K" + _randomNumberLaptop; }
        }
        if (_randomNameLaptop == 12)
        {
            if (_randomLetterLaptop == 1) { _inputFieldNameText.text = "Apole " + "A" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 2) { _inputFieldNameText.text = "Apole " + "B" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 3) { _inputFieldNameText.text = "Apole " + "C" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 4) { _inputFieldNameText.text = "Apole " + "D" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 5) { _inputFieldNameText.text = "Apole " + "E" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 6) { _inputFieldNameText.text = "Apole " + "F" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 7) { _inputFieldNameText.text = "Apole " + "G" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 8) { _inputFieldNameText.text = "Apole " + "H" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 9) { _inputFieldNameText.text = "Apole " + "I" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 10) { _inputFieldNameText.text = "Apole " + "J" + _randomNumberLaptop; }
            if (_randomLetterLaptop == 11) { _inputFieldNameText.text = "Apole " + "K" + _randomNumberLaptop; }
        }
    }
}
