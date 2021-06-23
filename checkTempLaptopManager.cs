using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkTempLaptopManager : MonoBehaviour
{
    [Header("Температура проца")]
    [SerializeField] private byte tempCPU;
    [SerializeField] private Text textTempCPU;
    [Header("Скорость проца")]
    [SerializeField] private float CPUFrequency;
    [SerializeField] private Text textCPUFrequency;
    [Header("Скорость кулера проца")]
    [SerializeField] private ushort CPURPM;
    [SerializeField] private Text textCPURPM;
    [Header("Температура видюхи")]
    [SerializeField] private byte tempGPU;
    [SerializeField] private Text textTempGPU;
    [Header("Температура ЖД")]
    [SerializeField] private byte tempHD;
    [SerializeField] private Text textTempHD;

    private void OnEnable()
    {
        tempCPU = (byte)Random.Range(70, 80);
        CPUFrequency = Random.Range(3.0f, 4.2f);
        CPURPM = (ushort)Random.Range(1600, 1800);
        tempGPU = (byte)Random.Range(65, 80);
        tempHD = (byte)Random.Range(35, 43);
    }

    void Update()
    {
        textTempCPU.text = "CPU: " + tempCPU + "℃";
        textCPUFrequency.text = "CPU Frequency: " + CPUFrequency.ToString("#.##") + "GHz";
        textCPURPM.text = "CPU Fans: " + CPURPM + " RPM";
        textTempGPU.text = "GPU: " + tempGPU + "℃";
        textTempHD.text = "Hard Disk: " + tempHD + "℃";
    }
}
