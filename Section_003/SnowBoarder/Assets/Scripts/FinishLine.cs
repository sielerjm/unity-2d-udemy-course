using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float loadDelay = 1f; // delay

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("You Finished!");
            Invoke("ReloadScene", loadDelay);  // delays reloading the scene by a set time
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);  // Loads scene at index 0
    }
}
