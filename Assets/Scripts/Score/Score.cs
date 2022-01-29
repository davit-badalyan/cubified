using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        Player player = FindObjectOfType<Player>();
        Text textComponent = GetComponent<Text>();

        textComponent.text = player.transform.position.z.ToString("0");
    }
}
