using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Firstcutscene : MonoBehaviour
{

    private float timingsceneon;
    private bool okay = false;
    private bool lel = true;
    // Start is called before the first frame update
    void Start()
    {
        timingsceneon = 13f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Animscene();
        Firstpart();
    }

    void Animscene ()
    {
        if(okay)
        {
            timingsceneon = 5000;
            Nextpart();
        }
        
    }

    void Firstpart()
    {
        if (lel)
        {
            if (Time.time >= timingsceneon)
            {

                okay = true;
                lel = false;
                SceneManager.LoadScene("Scenetwo");
            }
        }
    }
    


    void Nextpart()
    {
        if (Time.time <= timingsceneon)
        {
            SceneManager.LoadScene("Scenetwo");
        }
    }
}
