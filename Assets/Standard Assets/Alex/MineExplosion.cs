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

    void Update()
    {
       

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "bullet")
        {
            
            Instantiate(explosionEffect, transform.position, transform.rotation);
            mineRadius.SetActive(true);
            Destroy(gameObject);

        }
    }

}

