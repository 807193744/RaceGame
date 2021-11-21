using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rua : MonoBehaviour
{
    public GameObject obje;
    GameObject obj = null;
    // Use this for initialization 
    // Use this for initialization

    void Start()
    {

        obj = GameObject.FindGameObjectWithTag("sound");
        Debug.Log(obj);

        if (obj == null)
        {
            obj = (GameObject)Instantiate(obje);
            Debug.Log("2");
        }
        else
        {
            Debug.Log("3");

        }

    }

    // Update is called once per frame
    void Update()
    {
      

    }

}
