using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneChange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject.Find("SceneManager").GetComponent<SceneChange>().Main2Result();
        }
    }
}
