﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingAtPlayerC : MonoBehaviour
{



    private float ShotCounter;

    public float GapInBetweenShot;

    public float PlayerRange;

    public Transform Target;

    public GameObject EnemyBullet;

    public Transform EnemyFirePoint;


    void Start()
    {


        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ShotCounter = GapInBetweenShot;

        ShotCounter -= Time.deltaTime;
    }

    void Update()
    {


        ShotCounter -= Time.deltaTime;


        if (transform.localScale.z < 0 && Target.transform.position.z > transform.position.z && Target.transform.position.z < transform.position.z + PlayerRange && ShotCounter < 0)

        {

            Instantiate(EnemyBullet, EnemyFirePoint.position, EnemyFirePoint.rotation);

            ShotCounter = GapInBetweenShot;
        }


        if (transform.localScale.z > 0 && Target.transform.position.z < transform.position.z && Target.transform.position.z > transform.position.z - PlayerRange && ShotCounter < 0)

        {

            Instantiate(EnemyBullet, EnemyFirePoint.position, EnemyFirePoint.rotation);

            ShotCounter = GapInBetweenShot;

        }




    }
}

