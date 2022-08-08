using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMovement : MonoBehaviour
{
    private Vector3 vector;
    public Ball Ball;
    public GameObject basement;
    public Slider slider;

    //private Color _blue = new Color32(59, 204, 255, 255);
    //private Color _purple = new Color32(117, 51, 212, 255);        dynamic colour change

    void Start()
    {
        vector = basement.transform.position - Ball.transform.position;
        slider.maxValue = vector.magnitude;
    }

    void Update()
    {
        vector = basement.transform.position - Ball.transform.position;
        slider.value = vector.magnitude - 1.5f;
        /*slider.image.color = Color.Lerp(_blue, _purple, vector.magnitude);
        if (slider.value <= 0)
        {
            slider.image.color = _blue;
        }
        */
    }
}
