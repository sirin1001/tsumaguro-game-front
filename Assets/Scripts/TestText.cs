using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestText : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI count;
    void Start()
    {
       count=GameObject.Find("Count").GetComponent<TextMeshProUGUI>();
       //count.text="shfhr"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
