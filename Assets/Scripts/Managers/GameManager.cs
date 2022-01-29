using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded;
    private float restartDelay = 2.0f; 

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
        }
    }

    public void RestartGame()
    {
        Invoke("Restart", restartDelay);
    }

    private void Start()
    {
        //
    }

    private void Update()
    {
        //
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
