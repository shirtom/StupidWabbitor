﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogFloatings : MonoBehaviour
{
    // Private Log properties
    [SerializeField]
    private float rotationSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}