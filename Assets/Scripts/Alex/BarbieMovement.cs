﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieMovement : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.velocity = RandomVector(2f, 5f);
    }

    private Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        var z = Random.Range(min, max);
        return new Vector3(x,y, z);
    }

       
   
}
