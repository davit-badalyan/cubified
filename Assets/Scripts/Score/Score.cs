using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Transform player;

    private void Start()
    {
        //
    }

    private void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        score.text = player.position.z.ToString("0");
    }
}
