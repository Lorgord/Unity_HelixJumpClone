using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    internal CameraTrigger CurrentSector;
    public Bounce bounce;
    public GameResult GameResult;

    public Material FinishMaterial;
    public Material DeathMaterial;

    private Material _collisionMaterial;

    public int score;
    private bool check = false;

    private void OnCollisionEnter(Collision collision)
    {

        MaterialCheck(collision.gameObject);

        if (_collisionMaterial == DeathMaterial)
        {
            bounce.BounceStop();
            GameResult.GameOver(score);
            check = true;
        }
        
        if (_collisionMaterial == FinishMaterial)
        {
            bounce.BounceStop();
            GameResult.PlayerWin(score);
            check = true;
        }
        if (!check)
        {
            bounce.BallBounce();
        }

    }

    private void MaterialCheck(GameObject gameObject)
    {
        _collisionMaterial = gameObject.GetComponent<Renderer>().sharedMaterial;
    }
}