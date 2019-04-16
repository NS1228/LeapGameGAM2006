using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {


    public int StartingHealth = 100;

    public int CurrentHealth;

    public Slider HealthBar;




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


        CurrentHealth = 100;

        HealthBar.value = CurrentHealth;

        SceneManager.LoadScene("retry screen for doll game");
    


    }

}
