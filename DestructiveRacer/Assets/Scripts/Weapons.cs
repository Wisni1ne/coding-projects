using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class Weapons : MonoBehaviour
{

    public GameObject carFront;
    public GameObject carBack;

    public GameObject Explode;

    public int MissileDamage;
    public int MineDamage;

    public GameObject Missile;
    public float MissileDistance;
    public float MissileSpeed;
    public GameObject Mine;
    public GameObject Weapon;

    public int maxHealth;
    public int currentHealth;
    private bool isDead;

    public GameObject CarControls;

    public TextMeshProUGUI healthText;

    private AudioSource audioSource;
    public AudioClip MissileShot;
    public AudioClip MineDrop;
    public AudioClip ExplodeSound;

    void Start()
    {
        currentHealth = maxHealth;
        isDead = false;

        SetHealthText();

        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject newMissile = Instantiate(Missile, carFront.transform.position, carFront.transform.rotation) as GameObject;
            Rigidbody newMissileRigidbody = newMissile.GetComponent<Rigidbody>();
            newMissileRigidbody.AddForce(gameObject.transform.forward * MissileSpeed, ForceMode.Impulse);

            //RaycastHit hit;
            //if (Physics.Raycast(carFront.transform.position, carFront.transform.forward, out hit, MissileDistance))
            //{
            //Health health = hit.transform.GetComponent<Health>();
            //if (health != null)
            //{
            //health.TakeDamage(MissileDamage);
            //}
            //Instantiate(carFront, hit.point, Quaternion.identity);
            //}

            audioSource.clip = MissileShot;
            audioSource.Play();
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject newMine = Instantiate(Mine, carBack.transform.position, carBack.transform.rotation) as GameObject;
            Rigidbody newMineRigidbody = newMine.GetComponent<Rigidbody>();
            newMineRigidbody.AddForce(gameObject.transform.forward);

            //RaycastHit hit;
            //if (Physics.Raycast(carBack.transform.position, carBack.transform.forward, out hit, MissileDistance))
            //{
            //Health health = hit.transform.GetComponent<Health>();
            //if (health != null)
            //{
            //health.TakeDamage(MineDamage);
            //}
            //Instantiate(carBack, hit.point, Quaternion.identity);
            //}

            audioSource.clip = MineDrop;
            audioSource.Play();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hit");

        Instantiate(Explode, col.transform.position, Quaternion.identity);

        audioSource.clip = ExplodeSound;
        audioSource.Play();

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
