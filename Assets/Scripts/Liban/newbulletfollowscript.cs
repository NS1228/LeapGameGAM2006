using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbulletfollowscript : MonoBehaviour {


    public GameObject Bullet;

     Rigidbody rb;

    public float movespeed = 7f;

    public Transform Target;

    public Vector3 moveDirection;

	// Use this for initialization
	void Start () {


        rb = GetComponent<Rigidbody>();

        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);

        moveDirection = (Target.transform.position - transform.position).normalized * movespeed;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
