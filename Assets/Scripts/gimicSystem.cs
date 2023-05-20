using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimicSystem : MonoBehaviour
{
    Rigidbody rb;

    public float jumpForce;
    public GameObject Bomb;
    public GameObject cannon;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Quaternion rot = this.transform.rotation;
            Instantiate(Bomb, cannon.transform.position, rot);
        }

        Debug.Log(this.transform.rotation);
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("jumpBoard"))
        {
            rb.AddForce(transform.forward * jumpForce, ForceMode.Force);
        }
    }
}
