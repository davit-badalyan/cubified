using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int forwardMovementSpeed = 500;
    public int sideMovementSpeed = 1500;
    private bool rightPressed = false;
    private bool leftPressed = false;

    private void Start()
    {
        //
    }

    private void Update()
    {
        checkForInput();
    }

    private void FixedUpdate()
    {
        moveForward();
        checkForSideMovement();
    }

    private void checkForInput()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rightPressed = true;
        }
        else
        {
            rightPressed = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            leftPressed = true;
        } else
        {
            leftPressed = false;
        }
    }

    private void moveForward()
    {
        Rigidbody rb = transform.GetComponent<Rigidbody>();
        float force = forwardMovementSpeed * Time.deltaTime;
        rb.AddForce(0, 0, force);
    }

    private void checkForSideMovement()
    {
        Rigidbody rb = transform.GetComponent<Rigidbody>();
        float force = sideMovementSpeed * Time.deltaTime;

        if (rightPressed)
        {
            rb.AddForce(force, 0, 0);
        }

        if (leftPressed)
        {
            rb.AddForce(-force, 0, 0);
        }
    }
}
