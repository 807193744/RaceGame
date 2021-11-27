using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class updateResult : MonoBehaviour
{
  //  private readonly timer result_script;
    public Text result;
    public Text personalBest;
    private float totalTime;
    void Start()
    {

        totalTime = timer.result;
        result.text = "Result: "+ FormatTime(PlayerPrefs.GetFloat("HighScore")) ;

        if (!PlayerPrefs.HasKey("HighScore")) PlayerPrefs.SetFloat("HighScore", 99999);

        if (timer.totalTime < PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", totalTime);  
        }
        personalBest.text = "Personal best: " + FormatTime(PlayerPrefs.GetFloat("HighScore"));

    }
    private string FormatTime(float time)
    {
        int intTime = (int)time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = time * 1000;
        fraction = (fraction % 1000);
        string timeText = String.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, fraction);
        return timeText;
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }

    }

}
