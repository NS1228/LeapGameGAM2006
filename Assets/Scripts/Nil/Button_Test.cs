using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Test : MonoBehaviour
{

    public AudioClip ccorextsfx;
    AudioSource audioSource;

    public GameObject ccorect;
    public GameObject ffalse;

    public bool textfade;
    public bool textpasser;
    public float fadetimer = 0;
    public float fadetimerfalse = 0;
    // Start is called before the first frame update
    void Start()
    {
        textfade = false;
        textpasser = false;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Fadeaway();
        Textsender();
      
        
       
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
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);

            }
            else
            {
 
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");


            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 2 || Dance_Sets.SETS == 6)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");

            }
        }

        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 3 || Dance_Sets.SETS == 5 || Dance_Sets.SETS == 9)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
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
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 4)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }


        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 1 || Dance_Sets.SETS == 4 || Dance_Sets.SETS == 8)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
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
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 3 || Dance_Sets.SETS == 5)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }

        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 2 || Dance_Sets.SETS == 6)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
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
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {
                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }

        if (Dance_Sets.ROUNDS == 2)
        {
            if (Dance_Sets.SETS == 1 || Dance_Sets.SETS == 7)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }

        if (Dance_Sets.ROUNDS == 3)
        {
            if (Dance_Sets.SETS == 7)
            {
                print("CORRECT");
                Dance_Sets.SETS++;
                Debug.Log(Dance_Sets.SETS);
                ccorect.SetActive(true);
                fadetimer = Time.time + 1;
                textpasser = true;
                audioSource.PlayOneShot(ccorextsfx, 0.7F);
            }
            else
            {

                Debug.Log("WRONG");
                SceneManager.LoadScene("Dancegameretryscene");
            }
        }
    }

    public void Textsender()
    {
        if(textpasser == true)
        {
            textfade = true;
            textpasser = false;
        }
    }

    public void Fadeaway ()
    {
        if(textfade == true && Time.time >= fadetimer)
        {
            ccorect.SetActive(false);
            textfade = false;
        }
        
    }
}
