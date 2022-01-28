using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        //
    }

    private void Update()
    {
        //
    }

    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        transform.position = player.transform.position + offset;
    }
}
