using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dance_Test : MonoBehaviour
{

    private int set;

    public GameObject correctoncolor;
    public GameObject correctoncolor2;
    public GameObject correctoncolor3;


    // Start is called before the first frame update
    void Start()
    {
        //correctoncolor = GameObject.FindGameObjectWithTag("Pick");
        set = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        Tagchanger();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pick")
        {
            print("correct");
            set++;
            print(set);
            
        }
        else
        {
            SceneManager.LoadScene("test");
        }
    }


    private void Tagchanger()
    {
        if(set == 2)
        {
            correctoncolor.gameObject.tag = "RNG";
            correctoncolor2.gameObject.tag = "Pick";
            correctoncolor3.gameObject.tag = "RNG";
        }
        if (set == 3)
        {
            correctoncolor.gameObject.tag = "RNG";
            correctoncolor2.gameObject.tag = "RNG";
            correctoncolor3.gameObject.tag = "Pick";
        }
        
    }


}
