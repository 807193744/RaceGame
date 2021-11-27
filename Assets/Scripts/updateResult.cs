using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateResult : MonoBehaviour
{
  //  private readonly timer result_script;
    public Text result;
    public Text personalBest;
    private float totalTime;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = timer.totalTime;
        result.text = "Result: "+ totalTime + "s";

        if (PlayerPrefs.GetFloat("HighScore") == 0)
        {
            PlayerPrefs.SetFloat("HighScore", 9999);
        }
        if (timer.totalTime < PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", totalTime);  
        }
        personalBest.text = "Personal best: " + PlayerPrefs.GetFloat("HighScore") + "s";

    }

    // Update is called once per frame
    void Update()
    {
      //  localResult = timer.totalTime;
    }
}
