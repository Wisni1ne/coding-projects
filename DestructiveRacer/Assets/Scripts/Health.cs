using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    private bool isDead;

    public GameObject CarControls;

    public TextMeshProUGUI healthText;

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
            currentHealth = 0;
            Death();
        }
    }

    public void Death()
    {
        isDead = true;

        CarControls.GetComponent<CarController>().enabled = false;

        //       Destroy(gameObject);
    }

    public void SetHealthText()
    {
        healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
    }

}
