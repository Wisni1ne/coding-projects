using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PosUp : MonoBehaviour
{

    public TextMeshProUGUI posText;
    public bool Lead = false;
    public int posPlayer = 4;
    public int posOpp = 4;

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CarPos" && Lead == false)
        {
            Lead = true;
            posPlayer -= 1;
            posText.text = "" + posPlayer + " / " + posOpp;
        }
    }

}
