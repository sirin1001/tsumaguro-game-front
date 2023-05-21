using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    List<GameObject> CPList = new List<GameObject>();
    List<bool> CPEnt = new List<bool>();

    private void Start()
    {
        for(int i=0; i<transform.childCount; i++)
        {
            CPList.Add(transform.GetChild(i).gameObject);
            CPEnt.Add(false);
            CPList[i].GetComponent<CheckPoint>().setCPNumber(i);
        }
    }

    public void recvEnterCP(int Number){
        CPEnt[Number] = true;
        // Debug.Log(Number);
    }
}
