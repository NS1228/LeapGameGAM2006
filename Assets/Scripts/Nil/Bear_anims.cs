using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_anims : MonoBehaviour
{

    
    public GameObject Buttons;

    public AnimationClip lvl1;
    public AnimationClip lvl2;
    //public AnimationClip lvl3;

    Animation anim;


    private bool animswitch;
    // Start is called before the first frame update
    void Start()
    {
      anim = gameObject.GetComponent<Animation>();

        animswitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        Animplayer();   
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
            }
        }
        if (Dance_Sets.ROUNDS == 2)
        {
           
            anim.clip = lvl2;
            anim.Play();
        }
        if (Dance_Sets.ROUNDS == 3)
        {
            
            //anim.clip = lvl3;
            //anim.Play();
        }
    }
}
