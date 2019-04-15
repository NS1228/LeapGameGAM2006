using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ShootingScript : MonoBehaviour {



    public GameObject Bullet;

    public Transform FirePoint;

    public AudioSource GunShot;


	void Start () {
		
	}
	
	void Update () {



        if(Input.GetKey("g"))

        {

            GunShot.Play();

            Shoot();

        }
		
	}


    void Shoot()

    {

        Instantiate(Bullet, FirePoint.position, FirePoint.rotation);


    }


}
