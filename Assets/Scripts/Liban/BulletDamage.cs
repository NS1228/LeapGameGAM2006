using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.Audio;

public class BulletDamage : MonoBehaviour
{


    public int damagee = 20;

    public AudioSource DamageSound;






    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.tag == "Player")

        {

            HealthScript _health = other.gameObject.GetComponent<HealthScript>();

            _health.TakeDamage(damagee);


            // print("hit");

            CameraShaker ShakeShake = GameObject.Find("Leap Camera").GetComponent<CameraShaker>();

            ShakeShake.enabled = true;

            CameraShaker.Instance.ShakeOnce(3.4f, 3.4f, 0.5f, 0.5f);


            DamageSound.Play();

            Destroy(gameObject);

            print ("hello");


        }


    }


    // void OnCollisionEnter(Collision other)

   // {


      //  Destroy(gameObject);


   // }






}
