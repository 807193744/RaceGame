using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameraOnFinish : MonoBehaviour
{
    public GameObject endCamera;
    public GameObject followCamera;
    void OnTriggerEnter(Collider collider)
    {
        endCamera.GetComponent<Camera>().enabled = true;
        followCamera.GetComponent<Camera>().enabled = false;
    }
}
