using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{

    public TextMeshProUGUI input;

    public void NextScene()
    {
        PlayerPrefs.SetString("Name", input.text);
        SceneManager.LoadScene("Main");
    }

}
