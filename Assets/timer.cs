using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static int totalTime = 0;
    public Text visitBackTime;
    public Text HighSc;
    public Text text;
    int lapN = 1;
    public string b = null;
    public float score;
    void Start()
    {

        visitBackTime.text = "Time used: " + "0 s";
        StartCoroutine(CountDown());
        score = PlayerPrefs.GetFloat("HighScore");

        HighSc.text = ("Best: " + score + " s");

    }

    private IEnumerator CountDown()
    {

        while (1 > 0)
        {

            yield return new WaitForSeconds(1);
            totalTime++;
            visitBackTime.text = "Time used: " + (totalTime + " s");


        }
    }
  
}