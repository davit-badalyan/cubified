using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private void Start()
    {
        //
    }

    private void Update()
    {
        //
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Finish":
                CompleteLevel();
                break;
            default:
                break;
        }
    }

    private void CompleteLevel()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.CompleteLevel();
    }
}
