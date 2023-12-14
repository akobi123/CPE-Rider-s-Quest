using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera Camera;
    private float nextTimeToFire = 0f;
    public float fireingRate = 15f;
    
    void Start()
    {
        if(Input.GetMouseButtonDown(0) && Time.time >= nextTimeToFire)
        {
            Debug.Log("Pressed left-click.");
            nextTimeToFire = Time.time + 1f/fireingRate;
            shoot();
        }
    }

    // Update is called once per frame
    void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit))
        {
            Debug.Log("hit");
            if(hit.rigidbody != null ) {
                hit.rigidbody.AddForce(-hit.normal * 100);
            }
        }
    }
}
