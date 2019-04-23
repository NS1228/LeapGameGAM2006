using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject barbie1;
    public GameObject barbie2;
    public GameObject barbie3;
    public GameObject barbie4;
    public GameObject barbie5;
    public GameObject barbie6;

    public GameObject WinCanvas;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        win();
    }

    public void win()
    {
        if (barbie1 == null && barbie2 == null && barbie3 == null && barbie4 == null && barbie5 == null && barbie6 == null)
        {
            WinCanvas.SetActive(true);
        }
    }
}
