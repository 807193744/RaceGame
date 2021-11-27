using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class goin : MonoBehaviour
{
    public GameObject loadingScreen;

    void Start()
    {
        Screen.SetResolution(2560, 1440, true);
        Application.targetFrameRate = 144;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
         loadingScreen.SetActive(true);
         SceneManager.LoadSceneAsync(1);
        }
    }
}
