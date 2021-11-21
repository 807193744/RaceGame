using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public Text visitBackTime;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider SkyCar)
    {
        visitBackTime.text = "0 s";
    }
}
