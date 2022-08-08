using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{   
    private ScoreManager scoreManager;
    internal CameraTrigger CurrentSector;
    public Bounce bounce;
    public GameResult GameResult;

    public Material FinishMaterial;
    public Material DeathMaterial;

    private Material _collisionMaterial;

    private int _score;
    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    private void Start()
    { 
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void Update()
    {
        scoreManager.Score = _score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        MaterialCheck(collision.gameObject.GetComponent<Renderer>().sharedMaterial);

        if (_collisionMaterial == FinishMaterial)
        {
            GameResult.GameStop(true);
        }
        else if (_collisionMaterial == DeathMaterial)
        {
            GameResult.GameStop(false);
        }
        bounce.BallBounce(); 
        
    }

    private void MaterialCheck(Material material)
    {
        _collisionMaterial = material;
    }
}