using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pos : MonoBehaviour
{
    public TextMeshProUGUI posText;
    public int posPlayer;
    public int posOpp = 4;

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CarPos")
        {
            posPlayer += 1;
            posText.text = "" + posPlayer + " / " + posOpp;
        }
    }
}
