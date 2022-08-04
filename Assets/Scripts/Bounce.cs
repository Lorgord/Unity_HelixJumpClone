using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;
    public float BounceSpeed;

    public void BallBounce()
    {
        rb.AddForce(0, BounceSpeed, 0, ForceMode.Impulse);
    }
    public void BounceStop()
    {
        rb.velocity = Vector3.zero;
        Debug.Log("STOP PLS");
    }
}
