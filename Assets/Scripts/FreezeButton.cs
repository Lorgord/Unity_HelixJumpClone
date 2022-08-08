using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreezeButton : MonoBehaviour
{
    public TowerRotation TowerRotation;
    private bool _pauseSwitch = false;
    void Awake()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(PauseGame);
           
    }
    void PauseGame()
    {

        if (!_pauseSwitch)
        {
            Time.timeScale = 0;
            _pauseSwitch = true;
            TowerRotation.enabled = false;
        }
        else
        {
            Time.timeScale = 1;
            _pauseSwitch = false;
            TowerRotation.enabled = true;
        }
    }

}
