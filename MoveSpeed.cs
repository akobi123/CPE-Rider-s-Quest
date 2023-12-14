using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeed : MonoBehaviour
{
    public static float moveSpeed = 3f;
    public float speedIncreaseRate = 0.01f;

    private void Update()
    {
        moveSpeed += speedIncreaseRate * Time.deltaTime;
    }
}
