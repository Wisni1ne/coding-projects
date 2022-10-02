using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class T1Button : MonoBehaviour
{

    public Dropdown drop;

    public void NextScene()
    {
        int selection = drop.value;

        if (selection == 0)
        {
            SceneManager.LoadScene("Track One");
        }

        if (selection == 1)
        {
            SceneManager.LoadScene("Track One FPS");
        }

    }
}
