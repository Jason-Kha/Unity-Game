using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 1000f;
    public float jumpSpeed = 2000f;

    public int num = 0;

    bool forwardKey = false;
    bool backKey = false;
    bool rightKey = false;
    bool leftKey = false;
    bool spaceKey = false;

    bool onGround = false;

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

        if (Input.GetKey("space"))
        {
            spaceKey = true;
        }
        else
        {
            spaceKey = false;
        }
    }// end Update()

    void FixedUpdate()
    {
        if (forwardKey == true)
        {
            rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
        }

        if (backKey == true)
        {
            rb.AddForce(0, 0, -moveSpeed * Time.deltaTime);
        }

        if (rightKey == true)
        {
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (leftKey == true)
        {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0);
        }

        if (spaceKey == true && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpSpeed * Time.deltaTime, ForceMode.VelocityChange);
            onGround = false;
            Debug.Log("jump " + num);
            num = num + 1;
        }
    }// end FixedUpdate()

    
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "ground")
        {
            onGround = true;
        }
    }
}
