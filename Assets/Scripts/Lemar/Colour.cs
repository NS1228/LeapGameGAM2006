using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
     
{
    public Material Red;
    public Material Pink;
    public GameObject Cup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Cup.GetComponent<MeshRenderer>().material = Red;

        }
        if (other.gameObject.tag == "Floor")
        {
            Cup.GetComponent<MeshRenderer>().material = Pink;

        }
    }
}
