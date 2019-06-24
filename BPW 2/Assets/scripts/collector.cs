using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    float keycount = 0;
    public GameObject player;
    public GameObject key;
    public GameObject soundeffect;

    private void Start()
    {
        StartCoroutine(TimeBoy());
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        soundeffect.SetActive(true);
        keycount += 1;
        key.SetActive(false);
        TimeBoy();
        //load
    }

    IEnumerator TimeBoy()
    {
        print(Time.time);
        yield return new WaitForSeconds(10);
        print(Time.time);
    }
}
