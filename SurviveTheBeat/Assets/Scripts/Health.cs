using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    private bool isDead;

    public Text healthText;

    void Start()
    {
        currentHealth = maxHealth;
        isDead = false;

        SetHealthText();
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
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("Enemy die");
        isDead = true;
        Destroy(gameObject);
    }

    public void SetHealthText()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }

}
