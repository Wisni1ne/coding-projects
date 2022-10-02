using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door03 : MonoBehaviour
{

    public GameObject Door;
    public GameObject Spawn07;
    public GameObject Spawn08;

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

                Door.SetActive(false);
                Spawn07.SetActive(true);
                Spawn08.SetActive(true);
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
