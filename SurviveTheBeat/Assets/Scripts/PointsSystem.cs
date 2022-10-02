using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsSystem : MonoBehaviour
{

    public int points;

    public TextMeshProUGUI totalPoints;
    public TextMeshProUGUI costPoints;

    //public bool buyable;

    public GameObject zhealth;
    public GameObject rhythm;

    public GameObject Weapon01;
    public GameObject Weapon02;
    public GameObject Weapon03;
    public GameObject Weapon04;
    public GameObject Weapon05;
    public GameObject Weapon06;
    public GameObject Door01;
    public GameObject Door02;
    public GameObject Door03;
    public GameObject Door04;
    public GameObject Door05;
    public GameObject Door06;

    public void Start()
    {
        points = (int)PlayerPrefs.GetFloat("pointnum");

        UpdatePointsText();
        
        costPoints.enabled = false;
    }

    public void Update()
    {

        UpdatePointsText();

        if (points >= Weapon01.GetComponent<PickupPistol>().cost)
        {
            Weapon01.GetComponent<PickupPistol>().buyable = true;
        }
        else
        {
            Weapon01.GetComponent<PickupPistol>().buyable = false;
        }

        if (points >= Weapon02.GetComponent<PickupSub>().cost)
        {
            Weapon02.GetComponent<PickupSub>().buyable = true;
        }
        else
        {
            Weapon02.GetComponent<PickupSub>().buyable = false;
        }

        if (points >= Weapon03.GetComponent<PickupTac>().cost)
        {
            Weapon03.GetComponent<PickupTac>().buyable = true;
        }
        else
        {
            Weapon03.GetComponent<PickupTac>().buyable = false;
        }

        if (points >= Weapon04.GetComponent<PickupAssault>().cost)
        {
            Weapon04.GetComponent<PickupAssault>().buyable = true;
        }
        else
        {
            Weapon04.GetComponent<PickupAssault>().buyable = false;
        }

        if (points >= Weapon05.GetComponent<PickupSub>().cost)
        {
            Weapon05.GetComponent<PickupSub>().buyable = true;
        }
        else
        {
            Weapon05.GetComponent<PickupSub>().buyable = false;
        }

        if (points >= Weapon06.GetComponent<PickupTac>().cost)
        {
            Weapon06.GetComponent<PickupTac>().buyable = true;
        }
        else
        {
            Weapon06.GetComponent<PickupTac>().buyable = false;
        }

        if (points >= Door01.GetComponent<Door01>().cost)
        {
            Door01.GetComponent<Door01>().buyable = true;
        }
        else
        {
            Door01.GetComponent<Door01>().buyable = false;
        }

        if (points >= Door02.GetComponent<Door02>().cost)
        {
            Door02.GetComponent<Door02>().buyable = true;
        }
        else
        {
            Door02.GetComponent<Door02>().buyable = false;
        }

        if (points >= Door03.GetComponent<Door03>().cost)
        {
            Door03.GetComponent<Door03>().buyable = true;
        }
        else
        {
            Door03.GetComponent<Door03>().buyable = false;
        }

        if (points >= Door04.GetComponent<Door04>().cost)
        {
            Door04.GetComponent<Door04>().buyable = true;
        }
        else
        {
            Door04.GetComponent<Door04>().buyable = false;
        }

        if (points >= Door05.GetComponent<Door05>().cost)
        {
            Door05.GetComponent<Door05>().buyable = true;
        }
        else
        {
            Door05.GetComponent<Door05>().buyable = false;
        }

        if (points >= Door06.GetComponent<Door06>().cost)
        {
            Door06.GetComponent<Door06>().buyable = true;
        }
        else
        {
            Door06.GetComponent<Door06>().buyable = false;
        }

        if (points < 0)
        {
            points = 0;
        }

    }

    public void UpdatePointsText()
    {
        totalPoints.text = points.ToString();
    }
}
