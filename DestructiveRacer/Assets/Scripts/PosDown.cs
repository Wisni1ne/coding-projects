using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PosDown : MonoBehaviour
{

    public TextMeshProUGUI posText;
    public bool Lead;
    public int posPlayer;
    public int posOpp = 4;

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CarPos" && Lead == true)
        {
            Lead = false;
            posPlayer += 1;
            posText.text = "" + posPlayer + " / " + posOpp;
        }
    }

}
