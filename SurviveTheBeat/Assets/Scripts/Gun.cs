using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public GameObject bulletHit;

    public GameObject gunTip;
    public int gunDamage;
    public float maxGunDistance;

    public int maxBullets;
    private int currentBullets;
    public Text displayBulletCount;

    private AudioSource audioSource;
    public AudioClip bulletShot;

    private Animator animatorGun;

    public int maxEnemies;
    private int currentEnemies;
    public Text displayEnemyCount;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bulletShot;

        animatorGun = GetComponent<Animator>();

        currentBullets = maxBullets;
        UpdateBulletText();

        currentEnemies = maxEnemies;
        UpdateEnemyText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentBullets > 0)
        {
            currentBullets--;
            UpdateBulletText();

            RaycastHit hit;
            if (Physics.Raycast(gunTip.transform.position, gunTip.transform.forward, out hit, maxGunDistance))
            {
                Health health = hit.transform.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(gunDamage);

                    if (health.currentHealth <= 0)
                    {
                        currentEnemies--;
                        UpdateEnemyText();
                    }

                }
                Instantiate(bulletHit, hit.point, Quaternion.identity);
                //GameObject prefab = Instantiate(bulletHit, hit.point, Quaternion.identity);
                //Destroy(prefab, 2f);
            }
            audioSource.Play();

            animatorGun.SetTrigger("ActiveShoot");

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(ReloadBullets());
        }
    }

    void UpdateBulletText()
    {
        displayBulletCount.text = currentBullets.ToString() + " / " + maxBullets.ToString();
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

    void UpdateEnemyText()
    {
        displayEnemyCount.text = "Enemies Remaining: " + currentEnemies.ToString();
    }

}
