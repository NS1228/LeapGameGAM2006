using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFollowingPlayer : MonoBehaviour {

    public Transform TargetPlayer;

    public float speed;

    public float stoppingDistance;


	// Use this for initialization
	void Start () {

        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

		
	}
	
	// Update is called once per frame
	void Update () {


        if(Vector2.Distance(transform.position, TargetPlayer.position) > stoppingDistance)

        {

            transform.position = Vector3.MoveTowards(transform.position, TargetPlayer.position, speed * Time.deltaTime);
        }
		
	}
}
