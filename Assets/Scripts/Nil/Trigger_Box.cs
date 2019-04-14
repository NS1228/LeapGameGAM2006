using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_Box : MonoBehaviour
{
    public int ammo = 100;
    public static bool Canshoot;
    public static bool InTrigger;

   
   public Material Greenmat;

    public GameObject tbd;



    // Start is called before the first frame update
    void Start()
    {
        Canshoot = false;
        InTrigger = false;
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
        
        if(other.gameObject.tag == "Bottle")
        {
            other.gameObject.GetComponent<Renderer>().material = Greenmat;
            tbd = other.gameObject;
           
       }

    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Bottle")
        {
            
            tbd = null;

        }



    }
        public void Ammocounter()
    {
        if(Canshoot == true)
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
            tbd.SetActive(false);
        }
    }


  



}
