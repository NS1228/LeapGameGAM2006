using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupNamer : MonoBehaviour {
    public float upH = 3f;
    public Vector3 targetposition;
    public static int CheatCounter = 0;

  


    // Use this for initialization
    void Start () {
        targetposition = transform.position;
        CheatCounter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, targetposition, Time.deltaTime);

    }

   // void OnCollisionEnter(Collision other)

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cup")
        {
            other.gameObject.transform.parent = gameObject.transform;
        }
    }
    public void Lift()
    {
        if(CheatCounter == 0)
        { 
            targetposition = new Vector3
                (
              transform.position.x,
              upH,
              transform.position.z
                );
            CheatCounter++;

        }
        
    }

   
}
