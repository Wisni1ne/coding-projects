using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSub : MonoBehaviour
{
    public GameObject bulletHit;

    public GameObject gunTip;
    public int gunDamage;
    public float maxGunDistance;

    public int maxBullets;
    private int currentBullets;
    public TextMeshProUGUI displayBulletCount;

    private AudioSource audioSource;
    public AudioClip bulletShot;

    private Animator animatorGun;

    public GameObject rhythm;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bulletShot;

        animatorGun = GetComponent<Animator>();

        currentBullets = maxBullets;
        UpdateBulletText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentBullets > 0)
        {
            StartCoroutine(Shot());

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(ReloadBullets());
        }
    }

    void UpdateBulletText()
    {
        displayBulletCount.text = currentBullets.ToString() + " | " + maxBullets.ToString();
    }

    IEnumerator ReloadBullets()
    {
        currentBullets = 0;
        animatorGun.SetTrigger("ActiveReload");
        UpdateBulletText();
        yield return new WaitForSeconds(3);
        currentBullets = maxBullets;
        UpdateBulletText();
    }

    IEnumerator Shot()
    {

        RaycastHit hit;
        if (Physics.Raycast(gunTip.transform.position, gunTip.transform.forward, out hit, maxGunDistance))
        {

            if (rhythm.GetComponent<Rhythm>().goodHit)
            {
                ZombieHealth health = hit.transform.GetComponent<ZombieHealth>();
                if (health != null)
                {
                    health.TakeDamage(gunDamage);

                    if (health.currentHealth <= 0)
                    {

                    }

                }
            }

            for (int i = 0; i < 2; i++)
            {
                currentBullets--;
                UpdateBulletText();

                if (rhythm.GetComponent<Rhythm>().goodHit)
                {
                    Instantiate(bulletHit, hit.point, Quaternion.identity);
                }

                audioSource.Play();

                animatorGun.SetTrigger("ActiveShoot");

                yield return new WaitForSeconds(0.125f);
            }


            //GameObject prefab = Instantiate(bulletHit, hit.point, Quaternion.identity);
            //Destroy(prefab, 2f);
        }

        yield return new WaitForSeconds(0.1f);
    }

}
