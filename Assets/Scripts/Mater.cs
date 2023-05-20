using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mater : MonoBehaviour
{
    GameObject Car;
    float speed;
    GameObject Gauge;

    void Start()
    {
        Car = GameObject.Find("Car");
        Gauge = transform.Find("Gauge").gameObject;

    }
    void Update()
    {
        speed = Car.GetComponent<Rigidbody>().velocity.magnitude;
        Gauge.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 135-speed*2.5f);
    }
}
