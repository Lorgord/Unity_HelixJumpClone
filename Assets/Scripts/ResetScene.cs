using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    
    void Awake()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(Restart);
    }

    void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
   
}
