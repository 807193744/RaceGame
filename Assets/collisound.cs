using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisound : MonoBehaviour
{
    void Start()
    {
        Debug.Log("11");
    }
  
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Map_ground")
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("烂了");
        }
    }
   
}
