using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class RaceOver : MonoBehaviour
{

    public TextMeshProUGUI TopText;
    //public TextMeshProUGUI BotText;

    //public TextMeshProUGUI MinText;
    //public TextMeshProUGUI SecText;
    //public TextMeshProUGUI MilText;

    public Weapons player;

    public Button button;

    public bool isOver;

    void Start()
    {
        TopText.enabled = false;
        //BotText.enabled = false;
        //MinText.enabled = false;
        //SecText.enabled = false;
        //MilText.enabled = false;
        button.gameObject.SetActive(false);

        isOver = false;
    }

    void Update()
    {
        player = player.GetComponent<Weapons>();
        if (player.currentHealth <= 0 && isOver == false)
        {
            RaceOverText();
        }
    }

    public void RaceOverText()
    {
        TopText.enabled = true;
        //BotText.enabled = true;
        //MinText.enabled = true;
        //SecText.enabled = true;
        //MilText.enabled = true;
        button.gameObject.SetActive(true);

        isOver = true;
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
