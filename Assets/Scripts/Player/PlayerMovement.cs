using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int forwardMovementSpeed = 25;
    public int sideMovementSpeed = 50;
    private float fallBound = -2.0f;
    private bool rightPressed = false;
    private bool leftPressed = false;
    private bool playerFell = false;

    private void Start()
    {
        //
    }

    private void Update()
    {
        CheckForInput();
    }

    private void FixedUpdate()
    {
        MoveForward();
        CheckForPlayerFall();
        CheckForSideMovement();
    }

    private void CheckForInput()
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
        }
        else
        {
            leftPressed = false;
        }
    }

    private void MoveForward()
    {
        Rigidbody rb = transform.GetComponent<Rigidbody>();
        float force = forwardMovementSpeed * Time.deltaTime;

        rb.AddForce(0, 0, force, ForceMode.VelocityChange);
    }

    private void CheckForPlayerFall()
    {
        if (transform.position.y < fallBound && !playerFell)
        {
            GameManager gameManager = FindObjectOfType<GameManager>();

            playerFell = true;
            gameManager.EndGame();
            gameManager.RestartGame();
        }
    }

    private void CheckForSideMovement()
    {
        Rigidbody rb = transform.GetComponent<Rigidbody>();
        float force = sideMovementSpeed * Time.deltaTime;

        if (rightPressed)
        {
            rb.AddForce(force, 0, 0, ForceMode.VelocityChange);
        }

        if (leftPressed)
        {
            rb.AddForce(-force, 0, 0, ForceMode.VelocityChange);
        }
    }
}
