using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Secondcutscene : MonoBehaviour
{
    public float timingscenetwo;
    // Start is called before the first frame update
    void Start()
    {
        //timingscenetwo = 13f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timingscenetwo)
        {
            SceneManager.LoadScene("Babygame");
        }
    }
}