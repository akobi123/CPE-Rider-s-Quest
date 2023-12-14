using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Arrow : MonoBehaviour
{
    public GameObject Arrow_Emitter;

    public GameObject Arrow;

    public float Arrow_Force;

    private float nextTimeToFire = 0f;
    public float fireingRate = 1f;
    private bool lastGrabbed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((lastGrabbed == true && GrabbedShare.grabbed == false) && Time.time >= nextTimeToFire) {
            nextTimeToFire = Time.time + 1f / fireingRate;
            GameObject Temp_Arrow_Handler;

            Temp_Arrow_Handler = Instantiate(Arrow, Arrow_Emitter.transform.position, Arrow_Emitter.transform.rotation) as GameObject;

            //Temp_Arrow_Handler.transform.Rotate(Vector3.up * 90);
            //Temp_Arrow_Handler.transform.Rotate(Vector3.up * 90);

            Rigidbody Temp_Rigidbody;

            Temp_Rigidbody = Temp_Arrow_Handler.GetComponent<Rigidbody>();

            Temp_Rigidbody.AddForce(transform.right * -Arrow_Force);

            Destroy(Temp_Arrow_Handler, 10f);
        }

        lastGrabbed = GrabbedShare.grabbed;
    }
}
