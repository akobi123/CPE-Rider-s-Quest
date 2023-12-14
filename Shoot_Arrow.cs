using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//shoots arrow
public class Shoot_Arrow : MonoBehaviour
{
    public GameObject Arrow_Emitter; // attach arrowEmiter object (where the arrow should appear)
    public GameObject Arrow; // arrow prefab
    public float Arrow_Force; // force to shoot the arrow
    public float fireingRate = 1f;

    private float nextTimeToFire = 0f;
    private bool lastGrabbed = false;

    void Update()
    {
        // if the hand was grabbing but isn't grabbing now, and it is time to fire
        if((lastGrabbed == true && GrabbedShare.grabbed == false) && Time.time >= nextTimeToFire) {
            // update time to fire
            nextTimeToFire = Time.time + 1f / fireingRate;

            // create an arrow at arrow_Emmitter position
            GameObject Temp_Arrow_Handler;
            Temp_Arrow_Handler = Instantiate(Arrow, Arrow_Emitter.transform.position, Arrow_Emitter.transform.rotation) as GameObject;

            //Temp_Arrow_Handler.transform.Rotate(Vector3.up * 90);
            //Temp_Arrow_Handler.transform.Rotate(Vector3.up * 90);

            //add rigidbody to the arrow
            Rigidbody Temp_Rigidbody;
            Temp_Rigidbody = Temp_Arrow_Handler.GetComponent<Rigidbody>();
            //shoot the arrow
            Temp_Rigidbody.AddForce(transform.right * -Arrow_Force);

            // destroy the arrow in 10 seconds
            Destroy(Temp_Arrow_Handler, 10f);
        }

        // update the lastGrabbed variabel
        lastGrabbed = GrabbedShare.grabbed;
    }
}
