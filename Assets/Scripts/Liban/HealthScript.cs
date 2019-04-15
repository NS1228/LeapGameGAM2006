using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {


    public int StartingHealth = 100;

    public int CurrentHealth;

    public Slider HealthBar;

    public Transform RespawnPoint;



	// Use this for initialization
	void Start () {

        CurrentHealth = StartingHealth;

        HealthBar.value = StartingHealth;

		
	}
	
	public void TakeDamage (int amount) 

    {

        CurrentHealth -= amount;

        HealthBar.value = CurrentHealth;


        if(CurrentHealth <= 0)

        {

            Death();
           

        }


		
	}





    public void Death()

    {

        transform.position = RespawnPoint.position;

        CurrentHealth = 100;

        HealthBar.value = CurrentHealth;

        SceneManager.LoadScene("UI Retry Screen");
    


    }

}
