using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescnesx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RRetrythislevel ()
    {
        SceneManager.LoadScene("Babygame");
    }

    public void Gobacktomm ()
    {
        SceneManager.LoadScene("test");
    }
}
