using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text GameTimerText;

    public float GameTimer;

    public AudioSource Victory;

    private bool test = false;

    public GameObject EnemyB;

    public GameObject EnemyC;

    public Text Wave1;

    public Text Wave2;

    public Text Wave3;

    // Use this for initialization
    void Start()
    {


        GameTimer = 300.0f;

    }

    // Update is called once per frame
    void Update()
    {



        GameTimer -= Time.deltaTime;

        int seconds = (int)(GameTimer % 60);
        int minutes = (int)(GameTimer / 60) % 60;
        // int hours = (int)(GameTimer / 3600) % 24;

        string timerStrin = string.Format("{0:0}:{1:00}", minutes, seconds);

        GameTimerText.text = timerStrin;


     //   if (GameTimer <= 295.0f)

     //   {
      //      if (test == false)
      //      {

        //        Victory.Play();

         //       print("hey");
         //       test = true;

        //    }

    //    }



        if (GameTimer <= 295.0f)

        {

            //  GameTimerText.gameObject.SetActive(false);

            Victory.Stop();

            EnemyB.SetActive(true);


            EnemyShootingAtPlayer2ndWave Enemy2nd = GameObject.Find("doll A").GetComponent<EnemyShootingAtPlayer2ndWave>();

            Enemy2nd.enabled = true;


            EnemyShootingAtPlayer Enemy1st = GameObject.Find("doll A").GetComponent<EnemyShootingAtPlayer>();

            Enemy1st.enabled = false;


            Wave1.gameObject.SetActive(false);

            Wave2.gameObject.SetActive(true);




        }


        if (GameTimer <= 276.0f)

        {

            EnemyC.SetActive(true);

            EnemyShootingAtPlayer2ndWave4EnemyB Enemy2ndB = GameObject.Find("doll B").GetComponent<EnemyShootingAtPlayer2ndWave4EnemyB>();

            Enemy2ndB.enabled = true;


            EnemyShootingAtPlayerB Enemy1stB = GameObject.Find("doll B").GetComponent<EnemyShootingAtPlayerB>();

            Enemy1stB.enabled = false;

            Wave2.gameObject.SetActive(false);

            Wave3.gameObject.SetActive(true);


        }



        if (GameTimer <= 270.0f)


        {



            EnemyShootingAtPlayerC2ndWave EnemyC2nd = GameObject.Find("doll C").GetComponent<EnemyShootingAtPlayerC2ndWave>();

            EnemyC2nd.enabled = true;


            EnemyShootingAtPlayerC EnemyC1st = GameObject.Find("doll C").GetComponent<EnemyShootingAtPlayerC>();

            EnemyC1st.enabled = false;



        }



        if (GameTimer <= 0.0f)

        {

            SceneManager.LoadScene("congratulations screen for doll game");


            Destroy(gameObject);

        }





    }
}