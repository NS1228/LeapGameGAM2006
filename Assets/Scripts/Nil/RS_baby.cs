using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RS_baby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replaybaby ()
    {
        SceneManager.LoadScene("Babygame");
    }

    public void ReplayMM ()
    {
        SceneManager.LoadScene("test");
    }
}
