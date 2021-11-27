using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionPlay : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        

            GetComponent<AudioSource>().Play();

    
    }
}
