using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject Door01;
    public GameObject Door02;
    public GameObject Door03;
    public GameObject Door04;
    public GameObject Door05;
    public GameObject Door06;
    public GameObject Spawn01;
    public GameObject Spawn02;
    public GameObject Spawn03;
    public GameObject Spawn04;
    public GameObject Spawn05;
    public GameObject Spawn06;
    public GameObject Spawn07;
    public GameObject Spawn08;
    public GameObject Spawn09;
    public GameObject Spawn10;
    public GameObject Spawn11;
    public GameObject Spawn12;
    public GameObject Spawn13;
    public GameObject Spawn14;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Door01")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Door01.SetActive(false);
                    yield return new WaitForSeconds(1.0f);
                    Spawn03.SetActive(true);
                    Spawn04.SetActive(true);
                }
            }
            if (this.gameObject.tag == "Door02")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Door02.SetActive(false);
                    yield return new WaitForSeconds(1.0f);
                    Spawn05.SetActive(true);
                    Spawn06.SetActive(true);
                }
            }
            if (this.gameObject.tag == "Door03")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Door03.SetActive(false);
                    yield return new WaitForSeconds(1.0f);
                    Spawn07.SetActive(true);
                    Spawn08.SetActive(true);
                }
            }
            if (this.gameObject.tag == "Door04")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Door04.SetActive(false);
                    yield return new WaitForSeconds(1.0f);
                    Spawn09.SetActive(true);
                    Spawn10.SetActive(true);
                }
            }
            if (this.gameObject.tag == "Door05")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Door05.SetActive(false);
                    yield return new WaitForSeconds(1.0f);
                    Spawn11.SetActive(true);
                    Spawn12.SetActive(true);
                    Spawn13.SetActive(true);
                    Spawn14.SetActive(true);
                }
            }
            if (this.gameObject.tag == "Door06")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Door06.SetActive(false);
                    yield return new WaitForSeconds(1.0f);
                    Spawn11.SetActive(true);
                    Spawn12.SetActive(true);
                    Spawn13.SetActive(true);
                    Spawn14.SetActive(true);
                }
            }
        }
    }

}
