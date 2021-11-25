using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    float velocityY = 0;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
       // GameObject obj = this.gameObject;
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward *50* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * 50 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.down * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.up * 10 * Time.deltaTime);
        }

    }
}
