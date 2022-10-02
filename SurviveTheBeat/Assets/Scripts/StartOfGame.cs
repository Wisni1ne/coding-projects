using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOfGame : MonoBehaviour
{

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
    public GameObject Weapon01;
    public GameObject Weapon02;
    public GameObject Weapon03;
    public GameObject Weapon04;
    public GameObject Weapon05;

    void Start()
    {
        Spawn01.SetActive(true);
        Spawn02.SetActive(true);
        Spawn03.SetActive(false);
        Spawn04.SetActive(false);
        Spawn05.SetActive(false);
        Spawn06.SetActive(false);
        Spawn07.SetActive(false);
        Spawn08.SetActive(false);
        Spawn09.SetActive(false);
        Spawn10.SetActive(false);
        Spawn11.SetActive(false);
        Spawn12.SetActive(false);
        Spawn13.SetActive(false);
        Spawn14.SetActive(false);
        Weapon01.SetActive(true);
        Weapon02.SetActive(false);
        Weapon03.SetActive(false);
        Weapon04.SetActive(false);
        Weapon05.SetActive(false);
    }

    
    void Update()
    {
        
    }
}
