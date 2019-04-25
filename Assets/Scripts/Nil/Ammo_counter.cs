using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Ammo_counter : MonoBehaviour
{

    public float ammoinclip = 500;

    public Slider AmmoBar;



    void Start()
    {

        AmmoBar.value = ammoinclip;
        
        if(ammoinclip >= 500)
        {
            ammoinclip = 500;
        }
    }

    void Update()
    {
        print(ammoinclip);
        GameAgin();
    }

    public void GameAgin ()
        {
        if(ammoinclip <= 0)
        {
            SceneManager.LoadScene("retryammo");
        }
        if (Trigger_Box.Canshoot)
        {
            ammoinclip -= 1;
            AmmoBar.value = ammoinclip;

        }
    }

  
}
