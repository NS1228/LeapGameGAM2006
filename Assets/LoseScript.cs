using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{

    public GameObject BarbieInRoom;
    public GameObject Mine1;
    public GameObject Mine2;
    public GameObject Canvas;
    public GameObject Player;
    public GameObject PauseCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RetrySceneTrigger();
    }

    void RetrySceneTrigger()
    {

        if (Mine1 == null && Mine2 == null && BarbieInRoom.activeInHierarchy == true)
        {
            Player.SetActive(false);
            PauseCamera.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            Canvas.SetActive(true);
            
        }

    }

}
