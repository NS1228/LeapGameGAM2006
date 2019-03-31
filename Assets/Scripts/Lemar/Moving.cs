using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject ball;
    public Cup[] cups;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShuffleRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator ShuffleRoutine()
    {

        yield return new WaitForSeconds(2f);

        foreach (Cup cup in cups)
        {
            cup.Moveup();
        }
        yield return new WaitForSeconds(2f);

        Cup targetcup = cups[Random.Range(0, cups.Length)];
        targetcup.ball = ball;
        ball.transform.position = new Vector3(
            targetcup.transform.position.x,
            ball.transform.position.y,
           targetcup.transform.position.z);

        yield return new WaitForSeconds(2f);

        foreach (Cup cup in cups)
        {
            cup.MoveDown();
        }

        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 5; i++)
        {
            Cup cup1 = cups[Random.Range(0, cups.Length)];
            Cup cup2 = cup1;

            while (cup2 == cup1)
            {
                cup2 = cups[Random.Range(0, cups.Length)];
            }
            Vector3 cup1Position = cup1.targetposition;
            cup1.targetposition = cup2.targetposition;
            cup2.targetposition = cup1Position;

            yield return new WaitForSeconds(1f);

        }
    }
}
