using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float totalTime = 0;
    public Text visitBackTime;
    public static float result;
   // public Text HighSc;
 //   public Text text;
    //int lapN = 1;
    void Start()
    {

        //visitBackTime.text = "Time used: " + "0 s";
        //StartCoroutine(CountDown());
        //score = PlayerPrefs.GetFloat("HighScore");
        //HighSc.text = ("Best: " + score + " s");
        //startTime = Time.time;

    }
    private void Update()
    {
        // totalTime += Time.deltaTime;

        visitBackTime.text = FormatTime(Time.timeSinceLevelLoad);
        result = Time.timeSinceLevelLoad;
    }
    //Altered from https://answers.unity.com/questions/514378/timer-in-milliseconds-to-mmssms.html
    private string FormatTime(float time)
    {
        int intTime = (int)time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = time * 1000;
        fraction = (fraction % 1000);
        string timeText = String.Format("Time used: {0:00}:{1:00}.{2:000}", minutes, seconds, fraction);
        return timeText;
    }
    //private IEnumerator CountDown()
    //{

    //    while (true)
    //    {

    //        yield return new WaitForSeconds(1);
    //        totalTime++;
    //        visitBackTime.text = "Time used: " + (totalTime + " s");


    //    }
    //}

}