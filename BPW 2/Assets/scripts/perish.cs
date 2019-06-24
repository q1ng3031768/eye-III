using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("restart now");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.GetActiveScene(); 
        //Application.LoadLevel(Application.loadedLevel);

    }
}
