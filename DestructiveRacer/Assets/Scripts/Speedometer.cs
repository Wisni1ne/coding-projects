using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{

    public TextMeshProUGUI speedometer;
    public float speed;
    public UnityStandardAssets.Vehicles.Car.CarController car;

    void Start()
    {
        speed = car.CurrentSpeed;
        speedometer.text = speed.ToString("F0");
    }

    void Update()
    {
        speed = car.CurrentSpeed;
        speedometer.text = speed.ToString("F0");
    }
}
