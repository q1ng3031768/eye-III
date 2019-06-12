using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdeyeMode : MonoBehaviour
{

    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject go in objects)
        {
            go.gameObject.SetActive(true);
        }
    }
}