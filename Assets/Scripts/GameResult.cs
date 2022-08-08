using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameResult : MonoBehaviour
{
    public CameraMovement CameraMovement;
    public TowerRotation TowerRotation;
    public Canvas GUI;
    public Canvas PlayerWinUI;
    public Canvas PlayerLoseUI;
    public Ball Ball;

    private void Awake()
    {
        PlayerLoseUI.GetComponent<Canvas>();
        PlayerWinUI.GetComponent<Canvas>();
        GUI.GetComponent<Canvas>();
    }
    public void GameStop(bool finishMaterial)
    {
        if (finishMaterial) { PlayerWinUI.GetComponent<Canvas>().enabled = true; }

        else if (!finishMaterial) { PlayerLoseUI.GetComponent<Canvas>().enabled = true; }

        GUI.GetComponent<Canvas>().enabled = false;
        TowerRotation.enabled = false;
        Ball.bounce.BounceSwitch(true);
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
