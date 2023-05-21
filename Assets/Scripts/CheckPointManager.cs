using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    List<GameObject> CPList = new List<GameObject>();

    private void Start()
    {
        for(int i=0; i<transform.childCount; i++)
        {
            CPList.Add(transform.GetChild(i).gameObject);
            CPList[i].GetComponent<CheckPoint>().setCPNumber(i);
        }
    }
}
