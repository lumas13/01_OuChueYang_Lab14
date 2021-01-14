using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 5f;

    int red = 0;
    int purple = 0;
    int yellow = 0;
    int orange = 0;

    public GameObject redText;
    public GameObject purpleText;
    public GameObject yellowText;
    public GameObject orangeText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {
            red++;
            redText.GetComponent<Text>().text = "Red: " + red;
        }
        if (collision.gameObject.CompareTag("Purple"))
        {
            purple++;
            purpleText.GetComponent<Text>().text = "Purple: " + purple;

        }
        if (collision.gameObject.CompareTag("Yellow"))
        {
            yellow++;
            yellowText.GetComponent<Text>().text = "Yellow: " + yellow;
        }
        if (collision.gameObject.CompareTag("Orange"))
        {
            orange++;
            orangeText.GetComponent<Text>().text = "Orange: " + orange;
        }
    }
}
