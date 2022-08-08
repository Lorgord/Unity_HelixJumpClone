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
    public void BounceSwitch(bool bounceSwitch)
    {
        rb.isKinematic = bounceSwitch;
    }
}
