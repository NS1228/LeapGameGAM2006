using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSpeed : MonoBehaviour
{
    public static int Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Win() {
        SceneManager.LoadScene(2);
        Speed++;
    }
    public void Lose()
    {
        SceneManager.LoadScene(2);
        Speed--;
        if (Speed == 0) {
            Speed = 1;
        }
    }
}
