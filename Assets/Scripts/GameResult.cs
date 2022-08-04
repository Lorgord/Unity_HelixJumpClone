using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResult : MonoBehaviour
{
    public TowerRotation TowerRotation;

    public void GameOver(int score)
    {
        Debug.Log("GAMEOVER" + score);

        TowerRotation.enabled = false;
    }

    public void PlayerWin(int score)
    {
        Debug.Log("PlayerWin" + score);
        TowerRotation.enabled = false;
    }

}
