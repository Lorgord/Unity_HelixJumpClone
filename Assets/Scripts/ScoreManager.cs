using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int _score;
    public int Score { get { return _score; } set { _score = value; } }
    
    private Text scoreText;

        private void Update()
    {
        scoreText = gameObject.GetComponent<Text>();
        scoreText.text = "Score: " + _score;
        Debug.Log("Score is: " + _score);
        
    }

}
