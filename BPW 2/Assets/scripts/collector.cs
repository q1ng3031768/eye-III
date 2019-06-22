using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    float keycount = 0;
    public GameObject player;
    public GameObject thiskey;
    public GameObject soundeffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Debug.Log("did it???");
            soundeffect.SetActive(true);
            keycount += 1;
            thiskey.SetActive(false);
        }
    }
}
