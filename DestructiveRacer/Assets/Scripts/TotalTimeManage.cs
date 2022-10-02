using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TotalTimeManage : MonoBehaviour
{

    public static int MinCount;
    public static int SecCount;
    public static float MilCount;
    public static string MilDisplay;

    public TextMeshProUGUI MinText;
    public TextMeshProUGUI SecText;
    public TextMeshProUGUI MilText;

    public TextMeshProUGUI LapCount;
    //public int LapsDone = 1;
    //public int LapsToDo;

    void Update()
    {
        MilCount += Time.deltaTime * 100;

        if (MilCount >= 99)
        {
            MilCount = 0;
            SecCount += 1;
        }

        if (MilCount <= 9)
        {
            MilDisplay = MilCount.ToString("F0");
            MilText.text = "0" + MilDisplay;
        }
        else
        {
            MilDisplay = MilCount.ToString("F0");
            MilText.text = "" + MilDisplay;
        }

        if (SecCount <= 9)
        {
            SecText.text = "0" + SecCount + ".";
        }
        else
        {
            SecText.text = SecCount + ".";
        }

        if (SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if (MinCount <= 9)
        {
            MinText.text = "0" + MinCount + ":";
        }
        else
        {
            MinText.text = MinCount + ":";
        }

        //LapCount.text = "" + LapsDone + " / " + LapsToDo;

    }
}
