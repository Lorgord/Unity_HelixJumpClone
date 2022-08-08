using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotation : MonoBehaviour
{

    public Transform Tower;
    public float sens;
    private Vector3 _mouseStartPosition;
   

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _mouseStartPosition;
            Tower.Rotate(0, -delta.x * sens, 0);
        }
        _mouseStartPosition = Input.mousePosition;
    }

}
