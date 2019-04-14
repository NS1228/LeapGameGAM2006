using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDoll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
