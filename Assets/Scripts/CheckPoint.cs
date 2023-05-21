using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    GameObject CPManager;
    int CPNumber;

    private void Start()
    {
        CPManager = transform.parent.gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }

    public void setCPNumber(int Number)
    {
        CPNumber = Number;
    }
}
