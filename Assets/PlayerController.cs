using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;

    bool forwardKey = false;
    bool backKey = false;
    bool rightKey = false;
    bool leftKey = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            forwardKey = true;
        }
        else
        {
            forwardKey = false;
        }

        if (Input.GetKey("s"))
        {
            backKey = true;
        }
        else
        {
            backKey = false;
        }

        if (Input.GetKey("d"))
        {
            rightKey = true;
        }
        else
        {
            rightKey = false;
        }

        if (Input.GetKey("a"))
        {
            leftKey = true;
        }
        else
        {
            leftKey = false;
        }
    }

    void FixedUpdate()
    {
        if (forwardKey == true)
        {
            rb.AddForce(0, 0, moveSpeed);
        }

        if (backKey == true)
        {
            rb.AddForce(0, 0, -moveSpeed);
        }

        if (rightKey == true)
        {
            rb.AddForce(moveSpeed, 0, 0);
        }

        if (leftKey == true)
        {
            rb.AddForce(-moveSpeed, 0, 0);
        }
    }
}