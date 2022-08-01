using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMovement : MonoBehaviour
{
    private Vector3 vector;
    private GameObject ball;
    private GameObject basement;
    private Slider slider;

    private void Awake()
    {
        ball = GameObject.Find("Ball");
        basement = GameObject.Find("Base");
        slider = gameObject.GetComponent<Slider>();

    }
    void Start()
    {
        vector = basement.transform.position - ball.transform.position;
        slider.maxValue = vector.magnitude;

        Debug.Log(vector.magnitude);
        Debug.Log(slider.maxValue);
    }

    void Update()
    {
        vector = basement.transform.position - ball.transform.position;
        slider.value = vector.magnitude - 0.5f;
        slider.image.color = Color.Lerp(Color.yellow, Color.white, vector.magnitude / 10);
        if (slider.value <= 0)
        {
            slider.image.color = Color.green;
        }
    }
}
