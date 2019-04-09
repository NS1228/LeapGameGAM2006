using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : MonoBehaviour
{
    public GameObject LevelDown;
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            LevelDown.GetComponent<LevelSpeed>().Lose();
        }
    }
}
