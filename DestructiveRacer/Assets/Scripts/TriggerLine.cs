using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLine : MonoBehaviour
{

    public GameObject CompLapTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CompLapTrig.SetActive(false);
            HalfLapTrig.SetActive(true);
        }
    }

}
