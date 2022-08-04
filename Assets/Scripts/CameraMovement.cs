using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Ball Ball;
    public Vector3 CameraToScetorOffset;
    public float Speed;
    void Update()
    {
        if (Ball.CurrentSector == null) return; 
        Vector3 targetPosition = Ball.CurrentSector.transform.position + CameraToScetorOffset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}
