using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject ball;
    public Cup[] cups;
    public GameObject Cupbox1;
    public GameObject Cupbox2;
    public GameObject Cupbox3;
    public GameObject Cup1;
    public GameObject Cup2;
    public GameObject Cup3;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShuffleRoutine());
        Cupbox1.SetActive(false);
        Cupbox2.SetActive(false);
        Cupbox3.SetActive(false);
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
        yield return new WaitForSeconds(2f);

        Cupbox1.SetActive(true);
        Cupbox2.SetActive(true);
        Cupbox3.SetActive(true);
        GameObject.Find("Cup").GetComponent<Cup>().enabled = false;
        GameObject.Find("Cup2").GetComponent<Cup>().enabled = false;
        GameObject.Find("Cup3").GetComponent<Cup>().enabled = false;
    }
}
