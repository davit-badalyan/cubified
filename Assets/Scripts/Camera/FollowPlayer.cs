using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;

    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Player player = FindObjectOfType<Player>();
        transform.position = player.transform.position + offset;
    }
}
