using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance_Sets : MonoBehaviour
{

    public static int SETS;
    public static int ROUNDS;

    // Start is called before the first frame update
    void Start()
    {
        SETS = 1;
        ROUNDS = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Roundsetter();
    }


    public void Roundsetter()
    {
        if (ROUNDS == 1)
        {
            if (SETS == 6)
            {
                print("VICTORY... NEXT LEVEL");
                ROUNDS++;
                SETS = 1;
                Debug.Log(ROUNDS);
            }
        }

        if (ROUNDS == 2)
        {
            if (SETS == 8)
            {
                print("VICTORY... NEXT LEVEL");
                ROUNDS++;
                SETS = 1;
                Debug.Log(ROUNDS);
            }
        }
        if (ROUNDS == 3)
        {
            if (SETS == 10)
            {
                print("YOU WIN!");             
            }
        }
    }




}

