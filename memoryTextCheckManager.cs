using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryTextCheckManager : MonoBehaviour
{
    [SerializeField] private MemoryUpgrade _memoryUpgrade;
    [SerializeField] private CreateLaptop _createLaptop;

    void Update()
    {
        _memoryUpgrade.textCurrentROMLaptop.text = _createLaptop.currentROMLaptop + " GB";
        _memoryUpgrade.textCurrentRAMLaptop.text = _createLaptop.currentRAMLaptop + " GB";
    }
}
