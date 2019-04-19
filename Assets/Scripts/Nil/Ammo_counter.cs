using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ammo_counter : MonoBehaviour
{

    public float ammoinclip = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(ammoinclip);
        GameAgin();
    }

    public void GameAgin ()
        {
        if(ammoinclip <= 0)
        {
            SceneManager.LoadScene("Babygame");
        }
        if (Trigger_Box.Canshoot)
        {
            ammoinclip -= 1;
        }
    }

  
}
