using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class goin : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(2560, 1440, true);
        Application.targetFrameRate = -1;
    }

    void OnGUI()
    {

        if (Input.anyKeyDown)
        {

            SceneManager.LoadScene(1);
        }
    }
}
