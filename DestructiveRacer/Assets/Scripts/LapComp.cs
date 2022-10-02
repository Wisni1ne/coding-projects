using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapComp : MonoBehaviour
{

    public GameObject CompLapTrig;
    public GameObject HalfLapTrig;

    public TextMeshProUGUI LastMinText;
    public TextMeshProUGUI LastSecText;
    public TextMeshProUGUI LastMilText;

    public TextMeshProUGUI LapCount;
    public int LapsDone = 1;
    public int LapsToDo;

    void OnTriggerEnter()
    {

        LapsToDo = 3;
        LapsDone += 1;

        if (LapTimeManage.MilCount <= 9)
        {
            LapTimeManage.MilDisplay = LapTimeManage.MilCount.ToString("F0");
            LastMilText.text = "0" + LapTimeManage.MilDisplay;
        }
        else
        {
            LapTimeManage.MilDisplay = LapTimeManage.MilCount.ToString("F0");
            LastMilText.text = "" + LapTimeManage.MilDisplay;
        }

        if (LapTimeManage.SecCount <= 9)
        {
            LastSecText.text = "0" + LapTimeManage.SecCount + ".";
        }
        else
        {
            LastSecText.text = LapTimeManage.SecCount + ".";
        }

        if (LapTimeManage.MinCount <= 9)
        {
            LastMinText.text = "0" + LapTimeManage.MinCount + ":";
        }
        else
        {
            LastMinText.text = LapTimeManage.MinCount + ":";
        }

        LapTimeManage.MilCount = 0;
        LapTimeManage.SecCount = 0;
        LapTimeManage.MinCount = 0;

        LapCount.text = "" + LapsDone; // + " / " + LapsToDo;

        CompLapTrig.SetActive(false);
        HalfLapTrig.SetActive(true);
    }

}
