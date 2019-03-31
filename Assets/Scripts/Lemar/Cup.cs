using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour {
    public float downH = 2f;
    public float upH = 3f;
    public GameObject ball;
    public Vector3 targetposition;

    // Use this for initialization
    void Start () {
        targetposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, targetposition, Time.deltaTime);

        if (ball != null)
        {
            ball.transform.position = new Vector3
                (
                transform.position.x,
                ball.transform.position.y,
                transform.position.z
                );
        }
	}

    public void Moveup()
    {
        targetposition = new Vector3
            (
          transform.position.x,
          upH,
          transform.position.z
            );
    }
    public void MoveDown()
    {
        targetposition = new Vector3
            (
          transform.position.x,
          downH,
          transform.position.z
            );
    }
}
