using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float loadDelay = 1f; // delay
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;

            FindObjectOfType<PlayerController>().DisableControls();  // calling function from PlayerController.cs
            crashEffect.Play();  // plays particle effect

            GetComponent<AudioSource>().PlayOneShot(crashSFX, 0.05f);  // Plays a specific audio file (var, vol), aka allows you to have multiple in one script
                       


            Debug.Log("You Crashed!");
            Invoke("ReloadScene", loadDelay);  // delays reloading the scene by a set time

        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);  // Loads scene at index 0
    }
}
