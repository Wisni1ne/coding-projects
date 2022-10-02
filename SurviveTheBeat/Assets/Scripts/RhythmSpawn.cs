using System.Collections;
using UnityEngine;

public class RhythmSpawn : MonoBehaviour
{

    public GameObject LeftStandardImage01;
    public GameObject RightStandardImage01;
    public GameObject LeftStandardImage02;
    public GameObject RightStandardImage02;
    public GameObject LeftStandardImage03;
    public GameObject RightStandardImage03;
    public GameObject LeftStandardImage04;
    public GameObject RightStandardImage04;
    public int counting;

    public int tempoSet;
    public Animator animatorLeft01;
    public Animator animatorRight01;
    public Animator animatorLeft02;
    public Animator animatorRight02;
    public Animator animatorLeft03;
    public Animator animatorRight03;
    public Animator animatorLeft04;
    public Animator animatorRight04;

    public AudioSource audioSource;
    public AudioClip audio01;
    public AudioClip audio02;
    public AudioClip audio03;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        /*animatorLeft01 = LeftStandardImage01.GetComponent<Animator>();
        animatorRight01 = RightStandardImage01.GetComponent<Animator>();
        animatorLeft02 = LeftStandardImage02.GetComponent<Animator>();
        animatorRight02 = RightStandardImage02.GetComponent<Animator>();
        animatorLeft03 = LeftStandardImage03.GetComponent<Animator>();
        animatorRight03 = RightStandardImage03.GetComponent<Animator>();
        animatorLeft04 = LeftStandardImage04.GetComponent<Animator>();
        animatorRight04 = RightStandardImage04.GetComponent<Animator>();*/

        //StartCoroutine(RhythmSystem());
    }

    void Update()
    {
        //StartCoroutine(RhythmSystem());
    }

    public IEnumerator RhythmSystem(int tempoSet)
    {

        if (tempoSet == 1)
        {
            audioSource.clip = audio01;
            audioSource.Play();
            
            while (counting != -1)
            {
                
                
                
                
                if ((counting % 4) == 0)
                {
                    LeftStandardImage01.SetActive(true);
                    RightStandardImage01.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft01.SetTrigger("Tempo1");
                    animatorRight01.SetTrigger("Tempo1");
                    yield return new WaitForSeconds(0.5f);
                    counting++;
                }

                else if ((counting % 4) == 1)
                {
                    LeftStandardImage02.SetActive(true);
                    RightStandardImage02.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft02.SetTrigger("Tempo1");
                    animatorRight02.SetTrigger("Tempo1");
                    yield return new WaitForSeconds(0.5f);
                    counting++;
                }

                else if ((counting % 4) == 2)
                {
                    LeftStandardImage03.SetActive(true);
                    RightStandardImage03.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft03.SetTrigger("Tempo1");
                    animatorRight03.SetTrigger("Tempo1");
                    yield return new WaitForSeconds(0.5f);
                    counting++;
                }

                else if ((counting % 4) == 3)
                {
                    LeftStandardImage04.SetActive(true);
                    RightStandardImage04.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft04.SetTrigger("Tempo1");
                    animatorRight04.SetTrigger("Tempo1");
                    yield return new WaitForSeconds(0.5f);
                    counting++;
                }
            }
        }

        else if (tempoSet == 2)
        {
            audioSource.clip = audio02;
            audioSource.Play();
            
            while (counting != -1)
            {
                
                
                
                
                if ((counting % 4) == 0)
                {
                    LeftStandardImage01.SetActive(true);
                    RightStandardImage01.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft01.SetTrigger("Tempo2");
                    animatorRight01.SetTrigger("Tempo2");
                    yield return new WaitForSeconds(0.625f);
                    counting++;
                }

                else if ((counting % 4) == 1)
                {
                    LeftStandardImage02.SetActive(true);
                    RightStandardImage02.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft02.SetTrigger("Tempo2");
                    animatorRight02.SetTrigger("Tempo2");
                    yield return new WaitForSeconds(0.625f);
                    counting++;
                }

                else if ((counting % 4) == 2)
                {
                    LeftStandardImage03.SetActive(true);
                    RightStandardImage03.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft03.SetTrigger("Tempo2");
                    animatorRight03.SetTrigger("Tempo2");
                    yield return new WaitForSeconds(0.625f);
                    counting++;
                }

                else if ((counting % 4) == 3)
                {
                    LeftStandardImage04.SetActive(true);
                    RightStandardImage04.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft04.SetTrigger("Tempo2");
                    animatorRight04.SetTrigger("Tempo2");
                    yield return new WaitForSeconds(0.625f);
                    counting++;
                }
            }
        }

        else if (tempoSet == 3)
        {
            audioSource.clip = audio03;
            audioSource.Play();
            
            while (counting != -1)
            {
                
                
                
                
                if ((counting % 4) == 0)
                {
                    LeftStandardImage01.SetActive(true);
                    RightStandardImage01.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft01.SetTrigger("Tempo3");
                    animatorRight01.SetTrigger("Tempo3");
                    yield return new WaitForSeconds(0.375f);
                    counting++;
                }

                else if ((counting % 4) == 1)
                {
                    LeftStandardImage02.SetActive(true);
                    RightStandardImage02.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft02.SetTrigger("Tempo3");
                    animatorRight02.SetTrigger("Tempo3");
                    yield return new WaitForSeconds(0.375f);
                    counting++;
                }

                else if ((counting % 4) == 2)
                {
                    LeftStandardImage03.SetActive(true);
                    RightStandardImage03.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft03.SetTrigger("Tempo3");
                    animatorRight03.SetTrigger("Tempo3");
                    yield return new WaitForSeconds(0.375f);
                    counting++;
                }

                else if ((counting % 4) == 3)
                {
                    LeftStandardImage04.SetActive(true);
                    RightStandardImage04.SetActive(true);
                    animatorLeft01.ResetTrigger("Tempo1");
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
                    animatorRight04.ResetTrigger("Tempo3");
                    animatorLeft04.SetTrigger("Tempo3");
                    animatorRight04.SetTrigger("Tempo3");
                    yield return new WaitForSeconds(0.375f);
                    counting++;
                }
            }
        }

        //yield return new WaitForSeconds(2.0f);

        /*        yield return new WaitForSeconds(0.25f);
                LeftStandardImage01.SetActive(false);
                RightStandardImage01.SetActive(false);
                yield return new WaitForSeconds(0.25f);
                LeftStandardImage02.SetActive(false);
                RightStandardImage02.SetActive(false);
                yield return new WaitForSeconds(0.25f);
                LeftStandardImage03.SetActive(false);
                RightStandardImage03.SetActive(false);
                yield return new WaitForSeconds(0.25f);
                LeftStandardImage04.SetActive(false);
                RightStandardImage04.SetActive(false);*/
    }
}
