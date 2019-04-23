using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public Text timerLabel;
    public float time;

    public GameObject Player;
    public GameObject PauseCamera;
    public GameObject Canvas;
    public GameObject TimerCanvas;



    void Update()
    {
        time -= Time.deltaTime;

        int seconds = (int)(time % 60);
        int minutes = (int)(time / 60);
        int hours = (int)(time / 3600);

        string timerString = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

        timerLabel.text = timerString;

        if (seconds == 0)
        {
            TimerCanvas.SetActive(false);
            //Player.SetActive(false);
            //PauseCamera.SetActive(true);
            //Cursor.visible = true;
            //Cursor.lockState = CursorLockMode.None;
            //Time.timeScale = 0;
            Canvas.SetActive(true);
            

        }
    }


}