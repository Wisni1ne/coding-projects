using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{

    public Slider waveSlider;
    public Slider pointSlider;

    public TextMeshProUGUI waveText;
    public TextMeshProUGUI pointText;

    void Start()
    {
        float tempwave = PlayerPrefs.GetFloat("wavenum");
        float temppoint = PlayerPrefs.GetFloat("pointnum");
        waveSlider.value = tempwave + 1;
        pointSlider.value = temppoint / 500;
    }

    void Update()
    {
        SetWave();
        SetPoint();
    }

    public void SetWave()
    {
        waveText.text = waveSlider.value.ToString();
        PlayerPrefs.SetFloat("wavenum", (waveSlider.value - 1));
    }

    public void SetPoint()
    {
        pointText.text = (pointSlider.value * 500).ToString();
        PlayerPrefs.SetFloat("pointnum", (pointSlider.value * 500));
    }

}
