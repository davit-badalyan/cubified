using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.LoadNextLevel();
    }

    private void Start()
    {
        //
    }

    private void Update()
    {
        //
    }
}
