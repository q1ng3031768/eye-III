using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates { Idle = 0, Attack = 1, Patrol = 2}

public class valentijntest : MonoBehaviour
{

    public EnemyStates state;

    // Start is called before the first frame update
    void Start()
    {
        state = EnemyStates.Idle;
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
            case EnemyStates.Attack:

                break;

            case EnemyStates.Idle:

                //idle code

                //if(condition)
                //{
                    //state = EnemyStates.Attack;
                //}

                break;

            case EnemyStates.Patrol:
                break;

        }
    }
}
