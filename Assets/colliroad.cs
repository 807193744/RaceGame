using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliroad : MonoBehaviour
{
    public GameObject obj2;

    public GameObject obj;
    void OnTriggerEnter(Collider collider)
    {

        obj.SetActive(false);
        obj2.SetActive(true);
        

    }
    void Start()
    {
        obj2.SetActive(false);
    }



}
