using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSpeed : MonoBehaviour
{
    public static int Speed = 1;
    public Text SpeedT;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedT.text = "Speed: " + Speed + "/3";
    }
    public void Win()
    {
        SceneManager.LoadScene(4);
        Speed++;
        if (Speed == 4)
        {
            SceneManager.LoadScene(6);
            Speed = 1;
        }

    }
    public void Lose()
    {
        SceneManager.LoadScene(4);
        Speed--;
        if (Speed == 0)
        {
            SceneManager.LoadScene(5);
            Speed = 1;
        }
    }
}
