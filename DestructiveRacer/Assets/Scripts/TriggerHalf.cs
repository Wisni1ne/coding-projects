using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHalf : MonoBehaviour
{

    public GameObject CompLapTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CompLapTrig.SetActive(true);
            HalfLapTrig.SetActive(false);
        }
    }

}
