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

    private Color _blue = new Color32(59, 204, 255, 255);
    private Color _orange = new Color32(247, 147, 30, 255);

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
        slider.image.color = Color.Lerp(_blue, _orange, vector.magnitude / 10);
        if (slider.value <= 0)
        {
            //slider.image.color = _blue;
        }
    }
}
