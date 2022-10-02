using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTrack : MonoBehaviour
{

    public GameObject Tracker;
    public GameObject Waypoint00;
    public GameObject Waypoint01;
    public GameObject Waypoint02;
    public GameObject Waypoint03;
    public GameObject Waypoint04;
    public GameObject Waypoint05;
    public GameObject Waypoint06;
    public GameObject Waypoint07;
    public GameObject Waypoint08;
    public GameObject Waypoint09;
    public GameObject Waypoint10;
    public GameObject Waypoint11;
    public GameObject Waypoint12;
    public GameObject Waypoint13;
    public GameObject Waypoint14;
    public GameObject Waypoint15;
    public GameObject Waypoint16;
    public GameObject Waypoint17;
    public int MarkTrack;
    public string AITrackerID;

    void Update()
    {
        if (MarkTrack == 0)
        {
            Tracker.transform.position = Waypoint00.transform.position;
            Tracker.transform.rotation = Waypoint00.transform.rotation;
        }
        if (MarkTrack == 1)
        {
            Tracker.transform.position = Waypoint01.transform.position;
            Tracker.transform.rotation = Waypoint01.transform.rotation;
        }
        if (MarkTrack == 2)
        {
            Tracker.transform.position = Waypoint02.transform.position;
            Tracker.transform.rotation = Waypoint02.transform.rotation;
        }
        if (MarkTrack == 3)
        {
            Tracker.transform.position = Waypoint03.transform.position;
            Tracker.transform.rotation = Waypoint03.transform.rotation;
        }
        if (MarkTrack == 4)
        {
            Tracker.transform.position = Waypoint04.transform.position;
            Tracker.transform.rotation = Waypoint04.transform.rotation;
        }
        if (MarkTrack == 5)
        {
            Tracker.transform.position = Waypoint05.transform.position;
            Tracker.transform.rotation = Waypoint05.transform.rotation;
        }
        if (MarkTrack == 6)
        {
            Tracker.transform.position = Waypoint06.transform.position;
            Tracker.transform.rotation = Waypoint06.transform.rotation;
        }
        if (MarkTrack == 7)
        {
            Tracker.transform.position = Waypoint07.transform.position;
            Tracker.transform.rotation = Waypoint07.transform.rotation;
        }
        if (MarkTrack == 8)
        {
            Tracker.transform.position = Waypoint08.transform.position;
            Tracker.transform.rotation = Waypoint08.transform.rotation;
        }
        if (MarkTrack == 9)
        {
            Tracker.transform.position = Waypoint09.transform.position;
            Tracker.transform.rotation = Waypoint09.transform.rotation;
        }
        if (MarkTrack == 10)
        {
            Tracker.transform.position = Waypoint10.transform.position;
            Tracker.transform.rotation = Waypoint10.transform.rotation;
        }
        if (MarkTrack == 11)
        {
            Tracker.transform.position = Waypoint11.transform.position;
            Tracker.transform.rotation = Waypoint11.transform.rotation;
        }
        if (MarkTrack == 12)
        {
            Tracker.transform.position = Waypoint12.transform.position;
            Tracker.transform.rotation = Waypoint12.transform.rotation;
        }
        if (MarkTrack == 13)
        {
            Tracker.transform.position = Waypoint13.transform.position;
            Tracker.transform.rotation = Waypoint13.transform.rotation;
        }
        if (MarkTrack == 14)
        {
            Tracker.transform.position = Waypoint14.transform.position;
            Tracker.transform.rotation = Waypoint14.transform.rotation;
        }
        if (MarkTrack == 15)
        {
            Tracker.transform.position = Waypoint15.transform.position;
            Tracker.transform.rotation = Waypoint15.transform.rotation;
        }
        if (MarkTrack == 16)
        {
            Tracker.transform.position = Waypoint16.transform.position;
            Tracker.transform.rotation = Waypoint16.transform.rotation;
        }
        if (MarkTrack == 17)
        {
            Tracker.transform.position = Waypoint17.transform.position;
            Tracker.transform.rotation = Waypoint17.transform.rotation;
        }
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == AITrackerID)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTrack += 1;
            if (MarkTrack == 18)
            {
                MarkTrack = 0;
            }
            yield return new WaitForSeconds(0.5f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
