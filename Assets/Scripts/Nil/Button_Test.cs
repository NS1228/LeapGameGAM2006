using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Ballone()
    {
        if (Dance_Sets.ROUNDS == 1)
        {
            if (Dance_Sets.SETS == 1 || Dance_Sets.SETS == 3)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 2 || Dance_Sets.SETS == 6)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 3 || Dance_Sets.SETS == 5 || Dance_Sets.SETS == 9)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }
    }

    public void BallTwo()
    {
        if (Dance_Sets.ROUNDS == 1)
        {
            if (Dance_Sets.SETS == 2)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 4)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }


        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 1 || Dance_Sets.SETS == 4 || Dance_Sets.SETS == 8)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }
    }

    public void BallThree()
    {
        if (Dance_Sets.ROUNDS == 1)
        {
            if (Dance_Sets.SETS == 5)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 3 || Dance_Sets.SETS == 5)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 2 || Dance_Sets.SETS == 6)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }
    }

    public void BallFour()
    {
        if (Dance_Sets.ROUNDS == 1)
        {
            if (Dance_Sets.SETS == 4)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 1 || Dance_Sets.SETS == 7)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }

        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 7)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegame");
            }
        }
    }
}
