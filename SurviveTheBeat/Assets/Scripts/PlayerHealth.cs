using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public int damageToTake;
    private bool isDead;

    public int killCount;

    public bool takeHit;

    public TextMeshProUGUI healthText;

    public Canvas mainCanvas;
    public Canvas deadCanvas;

    public TextMeshProUGUI wavesText;
    public TextMeshProUGUI killsText;

    public GameObject zHealth;
    public GameObject wSystem;

    void Start()
    {
        currentHealth = maxHealth;
        isDead = false;

        mainCanvas.enabled = true;
        deadCanvas.enabled = false;

        killCount = 0;

        takeHit = true;

        SetHealthText();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" && takeHit)
        {
            TakeDamage(damageToTake);
            takeHit = false;
            StartCoroutine(HitDelay());
        }
    }

    public IEnumerator HitDelay()
    {
        yield return new WaitForSeconds(5f);
        takeHit = true;
    }

    public void TakeDamage(int damageToTake)
    {
        currentHealth -= damageToTake;

        if (isDead == false)
        {
            SetHealthText();
        }

        if (currentHealth <= 0 && isDead == false)
        {
            StartCoroutine(Death());
        }
    }

    public IEnumerator Death()
    {
        isDead = true;
        mainCanvas.enabled = false;
        deadCanvas.enabled = true;
        GetComponent<FirstPersonController>().enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        wavesText.text = "You Survived " + wSystem.GetComponent<WaveSystem>().wave.ToString() + " Waves";
        killsText.text = "Kills: " + killCount.ToString();

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Menu");
    }

    public void SetHealthText()
    {
        healthText.text = currentHealth.ToString() + " | " + maxHealth.ToString();
    }
}
