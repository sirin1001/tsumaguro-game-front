using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("Main");
    }
}
