using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rearLight : MonoBehaviour
{
    public GameObject rearLightObj;

    private void Start()
    {
        rearLightObj.SetActive(false);
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            rearLightObj.SetActive(true);
        }
        else
        {
            rearLightObj.SetActive(false);
        }
        //  rearLightObj.SetActive(false);

    }
}
