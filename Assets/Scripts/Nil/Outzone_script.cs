﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outzone_script : MonoBehaviour
{

    public Material Bluemat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "EnemyBullet")
        {
            other.gameObject.GetComponent<Renderer>().material = Bluemat;
            
        }

    }
}
