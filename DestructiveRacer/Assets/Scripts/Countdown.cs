using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{

    public TextMeshProUGUI CountdownText;
    public AudioSource Ready;
    public AudioSource Go;
    public GameObject LapTimer;
    public GameObject TotalTimer;
    public GameObject LastTimer;
    public GameObject CarControls;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);

        CountdownText.text = "3";
        Ready.Play();
        yield return new WaitForSeconds(1);

        CountdownText.text = "2";
        Ready.Play();
        yield return new WaitForSeconds(1);

        CountdownText.text = "1";
        Ready.Play();
        yield return new WaitForSeconds(1);

        CountdownText.text = "GO";
        Go.Play();

        LapTimer.SetActive(true);
        TotalTimer.SetActive(true);
        LastTimer.SetActive(true);
        CarControls.GetComponent<CarController>().enabled = true;

        yield return new WaitForSeconds(1);
        CountdownText.text = "";
    }

}
