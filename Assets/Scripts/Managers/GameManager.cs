using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LevelComplete levelCompleteUI;
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

    public void CompleteLevel()
    {
        levelCompleteUI.gameObject.SetActive(true);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
