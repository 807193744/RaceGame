using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Timers;

public class morecircle : MonoBehaviour
{

    int totalTime = 0;
    public Text visitBackTime;
    public Text HighSc;
    public Text text;
    int lapN = 1;
    public string b = null;
    public int score;
    void Start()
    {

        visitBackTime.text = "Time used: " +"0 s";
        StartCoroutine(CountDown());
        score = PlayerPrefs.GetInt("HighScore");

        HighSc.text = ("Best: " + score + " s");

    }

    private IEnumerator CountDown()
    {

        while (1 > 0)
        {

            yield return new WaitForSeconds(1);
            totalTime++;
            visitBackTime.text = "Time used: " + (totalTime + " s" );


        }
    }
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "Player")
        {
            
         b = text.text;
            text.text = ( b + "Lap " + lapN + ":   " + totalTime + "s\n");
            lapN ++;
            score = PlayerPrefs.GetInt("HighScore");

            if (score>totalTime  )
            {
                PlayerPrefs.SetInt("HighScore", totalTime);
                score = PlayerPrefs.GetInt("HighScore");

                HighSc.text = ("Best: " + score + " s");

            }
            
            totalTime = 0;
            visitBackTime.text = "Time used: " + "0 s";
            

        }
    }
   

}
