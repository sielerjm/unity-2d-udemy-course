using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touching");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Not Touching");
    }

}
