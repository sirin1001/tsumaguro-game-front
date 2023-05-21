using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    Rigidbody rb;

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 2000, ForceMode.Force);
        Invoke(nameof(Explosion), 1.5f);
    }

    void Explosion()
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(gameObject);
    }
}
