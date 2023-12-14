using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles one object following another
public class Follow : MonoBehaviour
{
    public GameObject followCamera; // object to follow
    public Vector3 offsetRotation = new Vector3(0f, 0f, 0f); // offset rotation from the followed object
    public Vector3 offsetPosition = new Vector3(0f, 0f, 0.5f); // offset position from the followed object
    public bool toFollowRotation; // flag variable to check if we should follow the rotation

    void Update()
    {
        // set the rotation
        transform.rotation = (toFollowRotation ? followCamera.transform.rotation * Quaternion.Euler(offsetRotation) : Quaternion.Euler(offsetRotation));
        // set the position
        transform.position = followCamera.transform.position + offsetPosition;
    }
}
