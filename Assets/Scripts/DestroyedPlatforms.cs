using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyedPlatforms : MonoBehaviour
{
    private int _score;
    public float bounce = 6f;
    private Rigidbody rb;
    public GameObject levelPassedUI;
    public GameObject levelFailedUI;
    public GameObject GUI;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            _score++;
            Destroy(collision.gameObject);
            GameObject.Find("Text").GetComponent<Text>().text = "Score: " + _score;
            GameObject.Find("ScoreSlider").GetComponent<Text>().text = "" + _score;
            rb.AddForce(0, bounce, 0, ForceMode.Impulse);
        }

        if (collision.gameObject.tag == "Death")
        {
            GUI.SetActive(false);
            levelFailedUI.SetActive(true);
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + _score;

        }

        else if (collision.gameObject.tag == "Base")
        {
            GUI.SetActive(false);
            levelPassedUI.SetActive(true);
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + _score;
        }

    }

}
