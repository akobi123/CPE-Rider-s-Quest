using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//This script makes the horse/camel bob back and forth creating the illusion of moving forward
public class HorseRunning : MonoBehaviour
{

    public float rotationAmount = 15f;
    public float rotationSpeed = 2f;
    private float initiial_angle = 0f;


    private void Start()
    {
        //store initial angle of the horse
        initiial_angle = gameObject.transform.localEulerAngles.x;
    }
    
    private void Update()
    {
        //use an occilating function to change the direction of the horse back and forth
        float rotation = Mathf.Sin(Time.time * rotationSpeed) * rotationAmount;
        transform.rotation = Quaternion.Euler(rotation + initiial_angle, 0f, 0f); //rotate on the x-axis
 
    }
}
