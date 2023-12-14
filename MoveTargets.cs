using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargets : MonoBehaviour
{
    // Start is called before the first frame update
    public float radius = 2f; // Radius of the circle
    public float speed = 2f; // Speed of movement
    public int difficulty = 2;
    private float angle = 0f;

    private float initial_x;
    private float initial_y;
    private void Start()
    {
        initial_x = transform.position.x;

        initial_y = transform.position.y;
    }
    void Update()
    {
        if(difficulty == 1)
        {
            // Calculate new position using sine and cosine functions
            float x = initial_x + radius * Mathf.Cos(angle);
            float y = initial_y + radius * Mathf.Sin(angle);
            
            // Set the position of the cube (keeping the original z-coordinate)
            this.transform.position = new Vector3(x, y, transform.position.z);
            //BlueCube.transform.position = new Vector3(-x, -y, transform.position.z);

            // Increase the angle for the next frame
        }
        else if(difficulty == 2)
        {
            float x = initial_x + radius * Mathf.Cos(angle);
            this.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        else if (difficulty == 3)
        {
            float y = initial_y + radius * Mathf.Cos(angle);
            this.transform.position = new Vector3(transform.position.x, y, transform.position.z);

        }
        angle += speed * Time.deltaTime;

    }
}
