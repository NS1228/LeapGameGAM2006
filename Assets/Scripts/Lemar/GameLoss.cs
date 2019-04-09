using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoss : MonoBehaviour
{
    public GameObject WinBox;
    public GameObject SpeedDown;
    // Start is called before the first frame update
    void Start()
    {
        WinBox.SetActive(true);
        SpeedDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            WinBox.SetActive(false);
            print("You Lose!");
            SpeedDown.SetActive(true);

        }
    }
}
