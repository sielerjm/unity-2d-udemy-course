using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 0, 0, 255);

    SpriteRenderer spriteRenderer;


    [SerializeField] float destroyDelay = 0.5f;
    bool pickedUp = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touching");
        // If (the thing we trigger is the package)
        // {
        //      Then print "package is packed up"
        // }
        if (collision.tag == "Package" && !pickedUp)
        {
            pickedUp = true;
            Debug.Log("Package is picked up!");
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }


        else if (collision.tag == "DeliveryLocation" && pickedUp == true )
        {
            Debug.Log("Package was delivered!");
            spriteRenderer.color = noPackageColor;
            pickedUp = false;
        }
    }

    // // When an object stops "touching" an object
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    Debug.Log("Not Touching");
    //}

}
