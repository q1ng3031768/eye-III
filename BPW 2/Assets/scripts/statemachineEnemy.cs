using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates { start = 0, seen = 1, dead = 2, kill = 3}

public class statemachineEnemy : MonoBehaviour
{

    public EnemyStates state;
    public float range = 30;
    public float speed = 10;
    private Transform target;
    public GameObject dagger;
    public GameObject keytoappear;
    public GameObject enemytodestroy;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("character").GetComponent<Transform>();
        state = EnemyStates.start;
    }

    // Update is called once per frame
    void Update()
    {
        ExecuteStates();
    }

    void ExecuteStates()
    {
        float distance = Vector2.Distance(target.position, this.transform.position);

        switch (state)
        {
            case EnemyStates.start:
                //code if player is close it will be seen
                if (distance <= range)
                {
                    state = EnemyStates.seen;
                }

                break;

            case EnemyStates.seen:
                //code for following
                var targetPos = new Vector2(target.position.x, transform.position.y);
                transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

                //code for flip
                if ((transform.position.x - target.position.x) < 0)
                {
                    Vector3 theScale = transform.localScale;
                    theScale.x = -2;
                    transform.localScale = theScale;

                }
                if ((transform.position.x - target.position.x) >= 0)
                {
                    Vector3 theScale = transform.localScale;
                    theScale.x = 2;
                    transform.localScale = theScale;
                }
                //code for dagger killing enemy
                if ((transform.position.y - dagger.transform.position.y) >= 5 && (transform.position.x - dagger.transform.position.x) >= 5)
                {
                    state = EnemyStates.dead;
                }

                //code for enemy killing you
                //if ((target.transform.position.x - transform.position.x) = 0) // && (target.transform.position.y - transform.position.y) = 0)
                    break;

            case EnemyStates.dead:
                //effects of dagger
                keytoappear.SetActive(true);
                enemytodestroy.SetActive(false);
                break;

            //case EnemyStates.kill:

                //reload scene
                //break;

        }
    }
}

