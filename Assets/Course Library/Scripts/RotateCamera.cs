﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float rs = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hi = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hi*rs*Time.deltaTime);
    }
}
