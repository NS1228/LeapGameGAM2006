using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosion : MonoBehaviour
{

    public GameObject explosionEffect;
    public GameObject mineRadius;

    public Material Greymaterials;
    public Material Redmaterials;
    public Material GreenMaterials;

    private bool change;

    void Start()
    {
        change = false; 
    }

    void Update()
    {

        StartCoroutine(Minetrigger());
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "bullet")
        {
            
            Instantiate(explosionEffect, transform.position, transform.rotation);
            mineRadius.SetActive(true);
            Destroy(gameObject);

        }
    }

    public IEnumerator Minetrigger()
    {
        if(change)
        {
            
            this.gameObject.GetComponent<Renderer>().material = Redmaterials;
            yield return new WaitForSeconds(2);
            this.gameObject.GetComponent<Renderer>().material = GreenMaterials;
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Blowup());


        }
            
        
    }

    public void Colourchange()
    {
       
        change = true;
    }

    private IEnumerator Blowup ()
    {
        change = false;
        Instantiate(explosionEffect, transform.position, transform.rotation);
        mineRadius.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        //mineRadius.SetActive(false);
        Destroy(gameObject);
        Destroy(mineRadius);
        
    }

    
    public void Colourreset ()
        {
        change = false;
        StopAllCoroutines();
        this.gameObject.GetComponent<Renderer>().material = Greymaterials;
        }
}

