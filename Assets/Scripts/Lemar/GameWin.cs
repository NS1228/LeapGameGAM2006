﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public GameObject LoseBox;
    public GameObject SpeedUp;

    // Start is called before the first frame update
    void Start()
    {
        LoseBox.SetActive(true);
        SpeedUp.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            print("You Win!");
            LoseBox.SetActive(false);
            SpeedUp.SetActive(true);
        }
    }
}
