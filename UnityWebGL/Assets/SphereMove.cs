
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using TMPro;

public class SphereMove : MonoBehaviour
{
    public GameObject _Player;
    private Rigidbody rb;

    internal float dx = 0;
    internal float dz = 0;
    private float _Speed;

    public TextMeshProUGUI Flasktext;

    void Start()
    {
        rb = _Player.GetComponent<Rigidbody>();
        _Speed = 0.5f;
    }


    void Update()
    {
        UnitySpehreMove();
    }

    private void UnitySpehreMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dx = -0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dx = 0.1f;
        }
        else
        {
            dx = 0.0f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            dz = 0.1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            dz = -0.1f;
        }
        else
        {
            dz = 0.0f;
        }
        var movement = new Vector3(dx, 0, dz);
        rb.AddForce(movement * _Speed);
    }

    public void FlaskSpeed(string flaskSpeed)
    {
        Flasktext.text = "Flask Speed is " + flaskSpeed;
        _Speed = float.Parse(flaskSpeed, CultureInfo.InvariantCulture);
    }

}