using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BgFadeInOut : MonoBehaviour
{
    public Image bgimages;
    public float showTime = 10;
    public float ShowTimeTrigger = 0;
    public float fadeTime = 3;
    public float fadeTimeTrigger = 0;
    private bool show = true;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ShowTimeTrigger += Time.deltaTime;
        if (ShowTimeTrigger > showTime)
        {
            if (fadeTimeTrigger >= 0 && fadeTimeTrigger < fadeTime)
            {
                fadeTimeTrigger += Time.deltaTime;
                if (show)
                {
                    bgimages.color = new Color(1, 1, 1, 1 - (fadeTimeTrigger / fadeTime));

                }
                else
                {
                    bgimages.color = new Color(1, 1, 1, (fadeTimeTrigger / fadeTime));

                }
            }
            else
            {
                fadeTimeTrigger = 0;
                ShowTimeTrigger = 0;
                if (show)
                {
                    show = false;
                }
                else
                {
                    show = true;
                }
            }
        }

    }
}