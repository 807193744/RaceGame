using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliroadC : MonoBehaviour
{
    public GameObject obj2;
    public GameObject obj;
    void OnTriggerEnter(Collider collider)
    {


        obj.SetActive(true);
        obj2.SetActive(false);



    }



}