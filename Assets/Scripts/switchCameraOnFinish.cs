using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchCameraOnFinish : MonoBehaviour
{
    public GameObject endCamera;
    public GameObject followCamera;
    public Image cinematicMask;
    public RawImage minimapMask;

    public RawImage minimap;
    public Image restartButton;
    private void Start()
    {
     //   cinematicMask.enabled = false;
    }
    void OnTriggerEnter(Collider collider)
    {
        endCamera.GetComponent<Camera>().enabled = true;
        followCamera.GetComponent<Camera>().enabled = false;
        cinematicMask.enabled = true;
        minimapMask.enabled = false;
        minimap.enabled = false;
        restartButton.enabled = false;
    }
}
