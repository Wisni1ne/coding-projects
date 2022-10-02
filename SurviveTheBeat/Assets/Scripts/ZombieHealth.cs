using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    private bool isDead;

    public int killCount;

    private Animator animatorZombie;

    private NavMeshAgent navZombie;

    public GameObject spawner;
    public GameObject rsystem;
    public GameObject psystem;
    public GameObject player;

    public GameObject LeftStandardImage01;
    public GameObject RightStandardImage01;
    public GameObject LeftStandardImage02;
    public GameObject RightStandardImage02;
    public GameObject LeftStandardImage03;
    public GameObject RightStandardImage03;
    public GameObject LeftStandardImage04;
    public GameObject RightStandardImage04;

    public Animator animatorLeft01;
    public Animator animatorRight01;
    public Animator animatorLeft02;
    public Animator animatorRight02;
    public Animator animatorLeft03;
    public Animator animatorRight03;
    public Animator animatorLeft04;
    public Animator animatorRight04;

    void Start()
    {
        animatorZombie = GetComponent<Animator>();

        navZombie = GetComponent<NavMeshAgent>();

        currentHealth = maxHealth;
        isDead = false;

    }

    public void TakeDamage(int damageToTake)
    {
        currentHealth -= damageToTake;

        player.GetComponent<PlayerHealth>().killCount += 1;

        if (isDead == false)
        {
            
        }

        if (currentHealth <= 0 && isDead == false)
        {
            StartCoroutine(Death());
        }
    }

    public IEnumerator Death()
    {
        Debug.Log("Enemy die");
        spawner.GetComponent<Spawn>().eCount--;
        psystem.GetComponent<PointsSystem>().points += 100;

        navZombie.isStopped = true;
        isDead = true;
        animatorZombie.SetTrigger("ActiveDeath");
        yield return new WaitForSeconds(6.1f);
        Destroy(gameObject);

        if (spawner.GetComponent<Spawn>().eCount == 0)
        {

            yield return new WaitForSeconds(3f);

            if (rsystem.GetComponent<RhythmSpawn>().tempoSet == 1)
            {
                LeftStandardImage01.SetActive(false);
                RightStandardImage01.SetActive(false);
                LeftStandardImage02.SetActive(false);
                RightStandardImage02.SetActive(false);
                LeftStandardImage03.SetActive(false);
                RightStandardImage03.SetActive(false);
                LeftStandardImage04.SetActive(false);
                RightStandardImage04.SetActive(false);
                animatorLeft01.SetTrigger("Reset");
                animatorRight01.SetTrigger("Reset");
                animatorLeft02.SetTrigger("Reset");
                animatorRight02.SetTrigger("Reset");
                animatorLeft03.SetTrigger("Reset");
                animatorRight03.SetTrigger("Reset");
                animatorLeft04.SetTrigger("Reset");
                animatorRight04.SetTrigger("Reset");
                rsystem.GetComponent<RhythmSpawn>().audioSource.Stop();
            }

            else if (rsystem.GetComponent<RhythmSpawn>().tempoSet == 2)
            {
                LeftStandardImage01.SetActive(false);
                RightStandardImage01.SetActive(false);
                LeftStandardImage02.SetActive(false);
                RightStandardImage02.SetActive(false);
                LeftStandardImage03.SetActive(false);
                RightStandardImage03.SetActive(false);
                LeftStandardImage04.SetActive(false);
                RightStandardImage04.SetActive(false);
                animatorLeft01.SetTrigger("Reset");
                animatorRight01.SetTrigger("Reset");
                animatorLeft02.SetTrigger("Reset");
                animatorRight02.SetTrigger("Reset");
                animatorLeft03.SetTrigger("Reset");
                animatorRight03.SetTrigger("Reset");
                animatorLeft04.SetTrigger("Reset");
                animatorRight04.SetTrigger("Reset");
                rsystem.GetComponent<RhythmSpawn>().audioSource.Stop();
            }

            else if (rsystem.GetComponent<RhythmSpawn>().tempoSet == 3)
            {
                LeftStandardImage01.SetActive(false);
                RightStandardImage01.SetActive(false);
                LeftStandardImage02.SetActive(false);
                RightStandardImage02.SetActive(false);
                LeftStandardImage03.SetActive(false);
                RightStandardImage03.SetActive(false);
                LeftStandardImage04.SetActive(false);
                RightStandardImage04.SetActive(false);
                animatorLeft01.SetTrigger("Reset");
                animatorRight01.SetTrigger("Reset");
                animatorLeft02.SetTrigger("Reset");
                animatorRight02.SetTrigger("Reset");
                animatorLeft03.SetTrigger("Reset");
                animatorRight03.SetTrigger("Reset");
                animatorLeft04.SetTrigger("Reset");
                animatorRight04.SetTrigger("Reset");
                rsystem.GetComponent<RhythmSpawn>().audioSource.Stop();
            }
        }

        /*animatorLeft01.ResetTrigger("Tempo1");
        animatorRight01.ResetTrigger("Tempo1");
        animatorLeft02.ResetTrigger("Tempo1");
        animatorRight02.ResetTrigger("Tempo1");
        animatorLeft03.ResetTrigger("Tempo1");
        animatorRight03.ResetTrigger("Tempo1");
        animatorLeft04.ResetTrigger("Tempo1");
        animatorRight04.ResetTrigger("Tempo1");
        animatorLeft01.ResetTrigger("Tempo2");
        animatorRight01.ResetTrigger("Tempo2");
        animatorLeft02.ResetTrigger("Tempo2");
        animatorRight02.ResetTrigger("Tempo2");
        animatorLeft03.ResetTrigger("Tempo2");
        animatorRight03.ResetTrigger("Tempo2");
        animatorLeft04.ResetTrigger("Tempo2");
        animatorRight04.ResetTrigger("Tempo2");
        animatorLeft01.ResetTrigger("Tempo3");
        animatorRight01.ResetTrigger("Tempo3");
        animatorLeft02.ResetTrigger("Tempo3");
        animatorRight02.ResetTrigger("Tempo3");
        animatorLeft03.ResetTrigger("Tempo3");
        animatorRight03.ResetTrigger("Tempo3");
        animatorLeft04.ResetTrigger("Tempo3");
        animatorRight04.ResetTrigger("Tempo3");*/

        rsystem.GetComponent<WaveSystem>().newWave = true;

    }
}
