using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dance_Game : MonoBehaviour
{

    private bool w1;
    private bool w2;
    private bool w3;

    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;


    // Start is called before the first frame update
    void Start()
    {
       // m_YourFirstButton.onClick.AddListener(TaskOnClick);
      //  m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        m_YourSecondButton.onClick.AddListener(() => ButtonClicked(41));
        m_YourFirstButton.onClick.AddListener(() => ButtonClicked(40));
        // m_YourThirdButton.onClick.AddListener(TaskOnClick);
        w1 = true;
        w2 = false;
        w3 = false;

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        //Debug.Log("Button clicked = " + buttonNo);

        if (w1)
        {
            
           
        }
      else
        {
            SceneManager.LoadScene("test");
        }

       

    }

    


}
