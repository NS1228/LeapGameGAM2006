using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Leap;
using LeapInternal;

public class Chooseminigame : MonoBehaviour
{
    public Material redzyorg;
    public Material greenzynew;

    public Finger fingers;


    public GameObject thatobj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Colorswap()
    {
        this.GetComponent<Renderer>().material = greenzynew;
    }

    public void Colorback()
    {
        this.GetComponent<Renderer>().material = redzyorg;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boxxy")
        {
            fingers.TipPosition.x = 123;
            print("lol");


        }


    }
}
