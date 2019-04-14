using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extended_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activetesting()
    {
        
        
    }

    public void Shootingobjs()
    {
        Trigger_Box.Canshoot = false;
        print("false");
    }

    public void Stopshooting()
    {
        Trigger_Box.Canshoot = true;
        print("true");
    }
}
