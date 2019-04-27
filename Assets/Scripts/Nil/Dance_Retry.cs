using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dance_Retry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retrybutton ()
    {
        SceneManager.LoadScene("Dancegame");
    }

    public void Mainmenufromdance()
    {
        SceneManager.LoadScene("PickScreen");
    }
}
