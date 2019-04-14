using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palm_test : MonoBehaviour
{

    public static bool shootble;
    // Start is called before the first frame update
    void Start()
    {
        shootble = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Testing ()
    {
        Debug.Log("FUCK ME");
    }

    public void Aiming ()
    {
        //instiante vfx
        shootble = true;
        
    }
}
