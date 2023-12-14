using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject followCamera;
    //public float offsetDistance = 0.5f;
    public Vector3 offsetRotation = new Vector3(0f, 0f, 0f);
    public Vector3 offsetPosition = new Vector3(0f, 0f, 0.5f);
    public bool toFollowRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //offsetPosition = followCamera.transform.forward * offsetDistance;
        transform.rotation = (toFollowRotation ? followCamera.transform.rotation * Quaternion.Euler(offsetRotation) : Quaternion.Euler(offsetRotation));
        transform.position = followCamera.transform.position + offsetPosition;
    }
}
