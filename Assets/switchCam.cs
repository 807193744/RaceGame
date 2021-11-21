using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCam : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    int count = 0;
    // Update is called once per frame
    void Start()
    {
        cam1.GetComponent<Camera>().enabled = true;
        cam1.GetComponent<AudioListener>().enabled = true;

        cam2.GetComponent<Camera>().enabled = false;
        cam2.GetComponent<AudioListener>().enabled = false;

    }
    void Update()
    {
        count = 0;
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam2.GetComponent<Camera>().enabled = true;
            cam2.GetComponent<AudioListener>().enabled = true;
            cam1.GetComponent<Camera>().enabled = false;
            cam1.GetComponent<AudioListener>().enabled = false;
          

            //count+=1;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            cam2.GetComponent<Camera>().enabled = false;
            cam2.GetComponent<AudioListener>().enabled = false;
            cam1.GetComponent<Camera>().enabled = true;
            cam1.GetComponent<AudioListener>().enabled = true;

     

            // count-=1;
        }

    }
}