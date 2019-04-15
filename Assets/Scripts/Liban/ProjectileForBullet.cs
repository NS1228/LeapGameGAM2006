using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileForBullet : MonoBehaviour {



    public Transform Target;

    public float FiringAngle = 45f;

    public float gravity = 9.8f;

    public Transform Projectile;
    private Transform myTransform;





	// Use this for initialization
	void Awake () {

        myTransform = transform;

		
	}
	
	// Update is called once per frame
	void Start () {


        StartCoroutine(SimulateProjectile());

		
	}


    IEnumerator SimulateProjectile()

    {


        yield return new WaitForSeconds(0.5f);


        Projectile.position = myTransform.position + new Vector3(0, 0.0f, 0);


        float target_Distance = Vector3.Distance(Projectile.position, Target.position);

        float projectile_Velocity = target_Distance / (Mathf.Sin(2 * FiringAngle * Mathf.Deg2Rad) / gravity);

        float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(FiringAngle * Mathf.Deg2Rad);
        float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(FiringAngle * Mathf.Deg2Rad);

        float flightduration = target_Distance / Vx;

        Projectile.rotation = Quaternion.LookRotation(Target.position - Projectile.position);

        float elapse_time = 0;


        while (elapse_time < flightduration)

        {

            Projectile.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

            elapse_time += Time.deltaTime;

            yield return null;
        }


    }
}
