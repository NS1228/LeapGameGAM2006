using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTest : MonoBehaviour
{

    public GameObject Player;
    public GameObject PauseCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.SetActive(false);
        PauseCamera.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
