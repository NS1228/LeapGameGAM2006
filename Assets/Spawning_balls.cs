using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_balls : MonoBehaviour
{
    public Transform balls;
    public Transform box;
    private bool bitch;
    // Start is called before the first frame update
    void Start()
    {
        bitch = true;
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Bitchfaggot());
                

        
    }

    IEnumerator Bitchfaggot ()
    {
        if (bitch)
        {
            bitch = false;
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(balls, box.transform.position, box.transform.rotation);
            yield return new WaitForSeconds(5);
        }

    }
}
