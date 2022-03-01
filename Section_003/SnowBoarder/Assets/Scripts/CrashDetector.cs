using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float loadDelay = 0.5f; // delay

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Debug.Log("You Crashed!");
            Invoke("ReloadScene", loadDelay);  // delays reloading the scene by a set time
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);  // Loads scene at index 0
    }
}
