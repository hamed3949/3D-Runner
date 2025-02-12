﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform player;

    Vector3 offset;
    [SerializeField]
    float smoothRate; 
    void Start()
    {
        offset = player.position - transform.position;

    }

  

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;
        Vector3 newPos = player.position - offset;

       transform.position= Vector3.Lerp(currentPos, newPos, smoothRate);
    }
}
