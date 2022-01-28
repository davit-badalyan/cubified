using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovementScript;

    private void Start()
    {
        //
    }

    private void Update()
    {
        //
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Obstacle":
                DisableMovementScript();
                break;
            default:
                break;
        }
    }

    private void DisableMovementScript()
    {
        playerMovementScript.enabled = false;
    }
}
