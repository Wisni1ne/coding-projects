using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class AIWeapons : MonoBehaviour
{

    public GameObject carFront;
    public GameObject carBack;

    public GameObject Explode;

    public Health CarHealth;

    public int MissileDamage;
    public int MineDamage;

    public GameObject Missile;
    public float MissileDistance;
    public float MissileSpeed;
    public GameObject Mine;
    public GameObject Weapon;

    public float randomShoot;
    public int randomType;

    public int maxHealth;
    public int currentHealth;
    private bool isDead;

    public GameObject CarControls;

    public TextMeshProUGUI healthText;

    void Start()
    {
        randomShoot = Random.Range(2.5f, 10f);

        currentHealth = maxHealth;
        isDead = false;

        SetHealthText();
    }

    void Update()
    {

        randomType = Random.Range(1, 3);

        if (Time.time > this.randomShoot)
        {
            this.randomShoot = Time.time + Random.Range(2.5f, 10f);

            if (randomType == 1)
            {
                GameObject newMissile = Instantiate(Missile, carFront.transform.position, carFront.transform.rotation) as GameObject;
                Rigidbody newMissileRigidbody = newMissile.GetComponent<Rigidbody>();
                newMissileRigidbody.AddForce(gameObject.transform.forward * MissileSpeed, ForceMode.Impulse);

            }

            if (randomType == 2)
            {
                GameObject newMine = Instantiate(Mine, carBack.transform.position, carBack.transform.rotation) as GameObject;
                Rigidbody newMineRigidbody = newMine.GetComponent<Rigidbody>();
                newMineRigidbody.AddForce(gameObject.transform.forward);

            }

        }

    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hit");

        Instantiate(Explode, col.transform.position, Quaternion.identity);

        if (col.gameObject.tag == "Missile")
        {
            Debug.Log("Missile");
            TakeDamage(MissileDamage);
            Debug.Log("Health " + currentHealth.ToString());
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Mine")
        {
            Debug.Log("Mine");
            TakeDamage(MineDamage);
            Debug.Log("Health " + currentHealth.ToString());
            Destroy(col.gameObject);
        }
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
            CarControls.GetComponent<CarController>().enabled = false;
        }

        if (currentHealth < 0)
        {
            currentHealth = 0;
            CarControls.GetComponent<CarController>().enabled = false;
        }

    }

    public void Death()
    {
        isDead = true;
    }

    public void SetHealthText()
    {
        healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
    }

}