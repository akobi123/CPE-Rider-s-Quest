using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject[] Trees; // Reference to the cube prefab
    public float delay = 1f; // Number of cubes to spawn
    public float moveSpeed = 5f; // Speed at which cubes move
    public float spawnArea = 5f; // Range of random spawn area
    float timeToSpawn;

    void Start()
    {
        timeToSpawn = Time.time;
    }

    void Update()
    {
        if (timeToSpawn < Time.time)
        {
            timeToSpawn = Time.time + delay;
            spawn();
            spawn();
            
        }
    }
    void spawn()
    {
        int sign = Random.Range(0, 100);
        //Debug.Log(sign);
        if (sign % 2 == 0) sign = 1;
        else sign = -1;
        Vector3 randomPosition = new Vector3(Random.Range(spawnArea, spawnArea * 4f) * sign, -0.1f, 30f);


        int index = Random.Range(0, 100) % Trees.Length;

        GameObject cube = Instantiate(Trees[index], randomPosition, Quaternion.identity);
        cube.AddComponent<Move>();
        cube.GetComponent<Move>().isTree = true;
        cube.GetComponent<Move>().moveSpeed = - MoveSpeed.moveSpeed;
    }
}