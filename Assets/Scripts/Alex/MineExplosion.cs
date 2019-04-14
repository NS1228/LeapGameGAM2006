using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosion : MonoBehaviour
{

    public GameObject explosionEffect;
    public GameObject mineRadius;

    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "bullet")
        {
            
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Instantiate(mineRadius);
            Destroy(gameObject);

        }
    }

}

