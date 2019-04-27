using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Confirmation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YesBitchFuckYes ()
    {
        if(Game_Select.confirm)
        {
            SceneManager.LoadScene("Dancegame");
            print("OKAY1");
        }
        if (Game_Select.confirmtwo)
        {
            SceneManager.LoadScene("Cupnball");
            print("OKAY2");
        }
        if (Game_Select.confirmthree)
        {
            SceneManager.LoadScene("Barbiedolls");
            print("OKAY3");
        }
        if (Game_Select.confirmfour)
        {
            SceneManager.LoadScene("Babygame");
            print("OKAY4");
        }
    }

    public void NoBitchFuckNo ()
    {
       //Game_Select.confirm = false;
      // Game_Select.confirmtwo = false;
      // Game_Select.confirmthree = false;
       //Game_Select.confirmfour = false;
    }
}
