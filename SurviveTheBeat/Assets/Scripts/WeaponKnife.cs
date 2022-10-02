using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponKnife : MonoBehaviour
{
    public GameObject bulletHit;

    public GameObject gunTip;
    public int gunDamage;
    public float maxGunDistance;

    public TextMeshProUGUI displayBulletCount;

/*    private AudioSource audioSource;
    public AudioClip bulletShot;*/

    private Animator animatorGun;

    public GameObject rhythm;

    void Start()
    {
/*        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bulletShot;*/

        animatorGun = GetComponent<Animator>();

        UpdateBulletText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateBulletText();

            if (rhythm.GetComponent<Rhythm>().goodHit)
            {

                RaycastHit hit;
                if (Physics.Raycast(gunTip.transform.position, gunTip.transform.forward, out hit, maxGunDistance))
                {
                    ZombieHealth health = hit.transform.GetComponent<ZombieHealth>();
                    if (health != null)
                    {
                        health.TakeDamage(gunDamage);

                        if (health.currentHealth <= 0)
                        {

                        }

                    }
                    Instantiate(bulletHit, hit.point, Quaternion.identity);
                    //GameObject prefab = Instantiate(bulletHit, hit.point, Quaternion.identity);
                    //Destroy(prefab, 2f);
                }

            }
/*            audioSource.Play();*/

            animatorGun.SetTrigger("ActiveShoot");

        }

    }

    void UpdateBulletText()
    {
        displayBulletCount.text = "-" + " | " + "-";
    }

}
