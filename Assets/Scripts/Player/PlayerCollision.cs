using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
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
        switch (collision.transform.tag)
        {
            case "Obstacle":
                EndGame();
                RestartGame();
                DisableMovementScript();
                break;
            default:
                break;
        }
    }

    private void EndGame()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }

    private void RestartGame()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.RestartGame();
    }

    private void DisableMovementScript()
    {
        PlayerMovement playerMovementScript = GetComponent<PlayerMovement>();
        playerMovementScript.enabled = false;
    }
}
