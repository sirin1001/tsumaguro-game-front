using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Syukai02 : MonoBehaviour
{
    int count=0;
    TextMeshProUGUI fukko;
    void OnTriggerEnter(Collider other)
    {  
         count=count+1;
        Debug.Log("Ç∑ÇËî≤ÇØÇΩÅI").GetComponent<TextMeshProUGUI>();
        //fukko.text="shfhr";
    }

    // Update is called once per frame
    void Update()
    
}
