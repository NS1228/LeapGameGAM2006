using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_Box : MonoBehaviour
{

    public int ammo = 100;
    public static bool Canshoot;
    public static bool Changetbd;


    public Material Greenmat;

    public GameObject tbd;
    public GameObject tbd2;
    public GameObject tbd3;


    public static bool timerx;
    public float timerfade = 0;

    // Start is called before the first frame update
    void Start()
    {
        Canshoot = false;
        Changetbd = false;
        timerx = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ammocounter();
        print(ammo);
        Objectdestroyer();

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "EnemyBullet")
        {
            other.gameObject.GetComponent<Renderer>().material = Greenmat;
            //tbd = other.gameObject;
            if (tbd3 == null)
            {
                tbd3 = other.gameObject;
            }
            else
            {
                if (tbd2 == null)
                {
                    tbd2 = other.gameObject;
                }
                else
                {
                    if (tbd == null)
                    {
                        tbd = other.gameObject;
                    }
                }
            }


        }

    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "EnemyBullet")
        {

            if (other.gameObject == tbd3)
            {
                tbd3 = null;
            }
            if (other.gameObject == tbd2)
            {
                tbd2 = null;
            }
            if (other.gameObject == tbd)
            {
                tbd = null;
            }

        }



    }
    public void Ammocounter()
    {
        if (Canshoot == true)
        {
            ammo -= 1;
        }

        if (ammo <= 0)
        {
            SceneManager.LoadScene("Babygame");
        }

    }

    public void Objectdestroyer()
    {

        if (Canshoot)
        {
            //timerx = true;
            //timerfade = Time.time + 1;
            // tbd.SetActive(false);
            // tbd2.SetActive(false);
            //tbd3.SetActive(false);

            GameObject.Destroy(tbd);
            GameObject.Destroy(tbd2);
            GameObject.Destroy(tbd3);
        

        }
    }






}

