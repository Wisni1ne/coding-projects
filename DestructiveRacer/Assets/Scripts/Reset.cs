using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{

    public GameObject Car;
    public float posX;
    public float rotX;
    public float posY;
    public float rotY;
    public float posZ;
    public float rotZ;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            posX = Car.transform.position.x - 1;
            Car.transform.transform.position.x.Equals(posX);
            posY = Car.transform.position.y - 1;
            Car.transform.transform.position.x.Equals(posY);
            posZ = Car.transform.position.z - 1;
            Car.transform.transform.position.x.Equals(posZ);
            rotX = 0;
            Car.transform.transform.rotation.x.Equals(rotX);
            rotY = 0;
            Car.transform.transform.rotation.y.Equals(rotY);
            rotZ = 0;
            Car.transform.transform.rotation.z.Equals(rotZ);
        }
    }
}
