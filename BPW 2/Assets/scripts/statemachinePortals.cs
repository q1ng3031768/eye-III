using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PortalStates { Start = 0, KeyOne = 1, KeyTwo = 2}

public class valentijntest : MonoBehaviour
{

    public PortalStates state;

    // Start is called before the first frame update
    void Start()
    {
        state = PortalStates.Start;
    }

    // Update is called once per frame
    void Update()
    {
        ExecuteStates();
    }

    void ExecuteStates()
    {
        switch (state)
        {
            case PortalStates.Start:

                //if(condition)
                //{
                //state = EnemyStates.KeyOne;
                //}

                break;

            case PortalStates.KeyOne:

                //idle code

                //if(condition)
                //{
                //state = EnemyStates.KeyTwo;
                //}

                break;

            case PortalStates.KeyTwo:

                break;

        }
    }
}
