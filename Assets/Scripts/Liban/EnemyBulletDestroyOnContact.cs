using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroyOnContact : MonoBehaviour{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider Other)


    {

        if(Other.gameObject.tag == ("EnemyBullet"))


        {


            Destroy(gameObject);

            print("HIT MAN");


        }


        
    }
}
