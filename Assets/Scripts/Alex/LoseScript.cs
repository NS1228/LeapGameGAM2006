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
    public GameObject TimerCanvas;

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
            TimerCanvas.SetActive(false);
            Canvas.SetActive(true);

        }

    }

}
