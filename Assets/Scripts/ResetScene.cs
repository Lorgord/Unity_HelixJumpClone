using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    private Ball Ball;
    public GameResult gameResult;
    void Awake()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(gameResult.GameRestart);
    }

   
}
