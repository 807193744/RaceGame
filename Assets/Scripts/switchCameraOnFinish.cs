using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchCameraOnFinish : MonoBehaviour
{
    public GameObject endCamera;
    public GameObject followCamera;
    public Image cinematicMask;
    private void Start()
    {
        cinematicMask.enabled = false;
    }
    void OnTriggerEnter(Collider collider)
    {
        endCamera.GetComponent<Camera>().enabled = true;
        followCamera.GetComponent<Camera>().enabled = false;
        cinematicMask.enabled = true;
    }
}
