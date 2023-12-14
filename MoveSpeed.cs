using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script stores speed of the objects in the game
public class MoveSpeed : MonoBehaviour
{
    public static float moveSpeed = 3f;
    public float speedIncreaseRate = 0.01f;

    private void Update()
    {
        // increase movespeed  
        moveSpeed += speedIncreaseRate * Time.deltaTime;
    }
}
