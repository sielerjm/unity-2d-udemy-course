using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // The Camera's position should be the same as the player's
    [SerializeField] GameObject thingToFollow;
    [SerializeField] int cameraDistance = -10;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0, cameraDistance);
    }
}
