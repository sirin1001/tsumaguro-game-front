using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallExpand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(Random.Range(1.0f, 10.0f), Random.Range(1.0f, 8.0f), Random.Range(1.0f, 10.0f));
    }

}
