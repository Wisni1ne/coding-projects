using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class AICarStart : MonoBehaviour
{

    public GameObject AICarControls;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);

        yield return new WaitForSeconds(1);

        yield return new WaitForSeconds(1);

        AICarControls.GetComponent<CarController>().enabled = true;

    }

}
