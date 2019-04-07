using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_anims : MonoBehaviour
{

    
    public GameObject Buttons;
    public GameObject startbutton;

    public AnimationClip lvl1;
    public AnimationClip lvl2;
    public AnimationClip lvl3;
    

   private Animation anim;

    public float Timingone = 0;
    public float Timingtwo = 0;
    public float Timingthree = 0;


    public static bool animswitch;
    public bool buttonswitch;
    // Start is called before the first frame update
    void Start()
    {
      anim = gameObject.GetComponent<Animation>();

        animswitch = false;
        buttonswitch = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        Animplayer();
        Timechecker();
        
    }

    public void Animplayer()
    {
        if (animswitch)
        {
            if (Dance_Sets.ROUNDS == 1)
            {

                anim.clip = lvl1;
                anim.Play();
                animswitch = false;
                Timingone = Time.time + 7;
                buttonswitch = true;
                
            }

                if (Dance_Sets.ROUNDS == 2)
                {

                    anim.clip = lvl2;
                    anim.Play();
                    animswitch = false;
                    Timingone = Time.time + 10;
                    buttonswitch = true;


            }


                if (Dance_Sets.ROUNDS == 3)
                {

                    anim.clip = lvl3;
                    anim.Play();
                    animswitch = false;
                    Timingone = Time.time + 15;
                    buttonswitch = true;


            }
            

        }
    }

    public void Startbutton ()
    {
        animswitch = true;
        print(animswitch);
        startbutton.SetActive(false);
        
    }

    public void Timechecker ()
    {
        
        if (buttonswitch && Time.time >= Timingone)
        {
            Buttons.SetActive(true);
            buttonswitch = false;
        }
    }
}
