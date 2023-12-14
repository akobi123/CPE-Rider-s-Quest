using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script spawns trees and bushes at random on the left or right of the player
public class SpawnTrees : MonoBehaviour
{
    public GameObject[] Trees; // Reference to the tree prefab
    public float delay = 1f; // Number of trees to spawn
    public float moveSpeed = 5f; // Speed at which tree move
    public float spawnArea = 5f; // Range of random spawn area
    float timeToSpawn;

    void Start()
    {
        // intiialize time to spwan
        timeToSpawn = Time.time;
    }

    void Update()
    {
        // if its time to spawn
        if (timeToSpawn < Time.time)
        {
            //update time to spawn
            timeToSpawn = Time.time + delay;
            //spawn 2 objects
            spawn();
            spawn();
            
        }
    }
    void spawn()
    {
        // choose where to spwan the target: left or right
        int sign = Random.Range(0, 100);
        //Debug.Log(sign);
        if (sign % 2 == 0) sign = 1;
        else sign = -1;

        // creatre random position with x coordinate as left or right of the player with distance random form spawnArea to 4*spawnArea
        Vector3 randomPosition = new Vector3(Random.Range(spawnArea, spawnArea * 4f) * sign, -0.1f, 30f);

        // generate random index
        int index = Random.Range(0, 100) % Trees.Length;

        // create the random object from the list at the generated position
        GameObject cube = Instantiate(Trees[index], randomPosition, Quaternion.identity);
        //Add scrit move and set isTree variable to true, and set speed to speed form MoveSpeed class
        cube.AddComponent<Move>();
        cube.GetComponent<Move>().isTree = true;
        cube.GetComponent<Move>().moveSpeed = - MoveSpeed.moveSpeed;
    }
}
