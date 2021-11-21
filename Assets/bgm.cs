using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgsound : MonoBehaviour
{
    public GameObject obje;
    GameObject obj = null;
    // Use this for initialization 
    // Use this for initialization

    void Start()
    {
        Debug.Log("000000");

        obj = GameObject.FindGameObjectWithTag("sound");
        if (obj == null)
        {
            Debug.Log("11111");
            obj = (GameObject)Instantiate(obje);
        }
        else
        {
            Debug.Log("22222");
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }

}
