using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Select : MonoBehaviour
{

    public static bool confirm;
    public static bool confirmtwo;
    public static bool confirmthree;
    public static bool confirmfour;
    // Start is called before the first frame update
    void Start()
    {
        confirm = false;
        confirmtwo = false;
        confirmthree = false;
        confirmfour = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "DG")
        {

            confirm = true;
            confirmtwo = false;
            confirmthree = false;
            confirmfour = false;
            // SceneManager.LoadScene("Dancegame");
            print("1");
            
        }
        if (collision.gameObject.tag == "CB")
        {

            confirmtwo = false;
            confirmtwo = true;
            confirmthree = false;
            confirmfour = false;
            //SceneManager.LoadScene("cupnball");
            print("2");

        }
        if (collision.gameObject.tag == "BA")
        {

            confirmtwo = false;
            confirmtwo = false;
            confirmthree = true;
            confirmfour = false;
            // SceneManager.LoadScene("Barbiedolls");
            print("3");
        }
        if (collision.gameObject.tag == "BM")
        {
            confirmtwo = false;
            confirmtwo = false;
            confirmthree = false;
            confirmfour = true;
            //SceneManager.LoadScene("Babygame");
            print("4");
        }
    }

    

    
}
