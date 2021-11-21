using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float totalTime = 0;

    public Text visitBackTime;
    void Start()
    {

        visitBackTime.text = "0 s";
        StartCoroutine(CountDown());
    }

    private IEnumerator CountDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            totalTime++;
            visitBackTime.text = (totalTime +  "s");

        }
    }
}