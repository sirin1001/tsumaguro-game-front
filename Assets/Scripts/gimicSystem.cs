using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class gimicSystem : MonoBehaviourPunCallbacks
{
    Rigidbody rb;

    public float jumpForce;
    public GameObject Bomb, slowedJumpBoard, wall;
    public GameObject cannon, backCannon, leftCannon, rightCannon;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Quaternion rot = this.transform.rotation;
                Instantiate(Bomb, cannon.transform.position, rot);
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Quaternion rot = backCannon.transform.rotation;
                Instantiate(Bomb, backCannon.transform.position, rot);
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                Quaternion rot = leftCannon.transform.rotation;
                Instantiate(Bomb, leftCannon.transform.position, rot);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                Quaternion rot = rightCannon.transform.rotation;
                Instantiate(Bomb, rightCannon.transform.position, rot);
            }
        }

    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("jumpBoard"))
        {
            rb.AddForce(transform.forward * jumpForce, ForceMode.Force);
        }
    }
}
