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
    public GameObject loadingScreen;

    void Start()
    {

        totalTime = GameEnd.actuallResult;
         result.text = "Result: "+ FormatTime(totalTime);
        //result.text = "Result: " + FormatTime(totalTime) + "High: " + PlayerPrefs.GetFloat("HighScore");
       // if (!PlayerPrefs.HasKey("HighScore")) PlayerPrefs.SetFloat("HighScore", 99999.0F);

     
        if (totalTime < PlayerPrefs.GetFloat("HighScore")|| PlayerPrefs.GetFloat("HighScore") ==0.0f)
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
            loadingScreen.SetActive(true);

            SceneManager.LoadScene(1);
        }

    }

}
