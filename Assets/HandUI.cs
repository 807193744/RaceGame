using UnityEngine;
using System.Collections;
public class HandUI : MonoBehaviour
{
    public Transform Hand;//文字对应3D的物体
    Vector3 screenPos;
    private void Update()
    {

        screenPos = Camera.main.WorldToScreenPoint(Hand.position);
        transform.position = screenPos;
    }
}
