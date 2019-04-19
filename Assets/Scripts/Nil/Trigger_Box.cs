using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_Box : MonoBehaviour
{

    //public int ammo = 100;
    public static bool Canshoot;
    public static bool Changetbd;


    public Material Greenmat;

    public GameObject tbd;
    public GameObject tbd2;
    public GameObject tbd3;

    public GameObject gmm;

    public static bool timerx;
    public float timerfade = 0;

    private bool addammo;

    // Start is called before the first frame update
    void Start()
    {
        Canshoot = false;
        Changetbd = false;
        timerx = false;
        addammo = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Ammocounter();
       // print(ammo);
        Objectdestroyer();
        Greenammo();

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "EnemyBullet")
        {
            //addammo = true;
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

            if (this.gameObject.tag == "GREENZONE")
            {
                gmm.GetComponent<Ammo_counter>().ammoinclip += 50;
                Debug.Log("PLUS AMMO");
                addammo = false;
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

    public void Greenammo ()
    {
        
    }






}

