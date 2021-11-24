using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raceEnd : MonoBehaviour
{
    public GameObject endCamera;
    public GameObject followCamera;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            endCamera.GetComponent<Camera>().enabled = true;
            followCamera.GetComponent<Camera>().enabled = false;
        }
    }
}
