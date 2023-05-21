using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowForword : MonoBehaviour
{
    Rigidbody rb;
    public float Force;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Force, ForceMode.Force);
    }
}
