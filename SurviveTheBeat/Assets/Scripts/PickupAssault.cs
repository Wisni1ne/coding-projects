using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupAssault : MonoBehaviour
{
    public GameObject Weapon01;
    public GameObject Weapon02;
    public GameObject Weapon03;
    public GameObject Weapon04;
    public GameObject Weapon05;

    public GameObject points;
    public bool buyable;

    public TextMeshProUGUI costPoints;
    public int cost;

    void Start()
    {

    }

    void Update()
    {

    }
    public IEnumerator OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DisplayCost();
            if (Input.GetKeyDown(KeyCode.F) && buyable)
            {
                points.GetComponent<PointsSystem>().points -= cost;
                costPoints.enabled = false;

                if (Weapon01.activeInHierarchy || Weapon02.activeInHierarchy || Weapon03.activeInHierarchy || Weapon04.activeInHierarchy)
                {
                    Weapon01.SetActive(false);
                    Weapon02.SetActive(false);
                    Weapon03.SetActive(false);
                    Weapon04.SetActive(false);
                    Weapon05.SetActive(true);
                }
                yield return new WaitForSeconds(1.0f);
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            costPoints.enabled = true;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            costPoints.enabled = false;
        }
    }

    public void DisplayCost()
    {
        costPoints.text = "Press F to BUY: " + cost.ToString();
    }

}
