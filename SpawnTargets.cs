using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnTargets : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
    public float delay = 1f; // Number of cubes to spawn
    public float moveSpeed = 1f; // Speed at which cubes move
    public float spawnArea = 1f; // Range of random spawn area
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
            int sign = Random.Range(0, 100);
            //Debug.Log(sign);
            if (sign % 2 == 0) sign = 1;
            else sign = -1;
            Vector3 randomPosition = new Vector3(Random.Range(spawnArea, spawnArea * 5f) * sign, Random.Range(2f, 3f*spawnArea), 25f);

            GameObject cube = Instantiate(cubePrefab, randomPosition, Quaternion.identity);
            cube.AddComponent<Move>();
            cube.GetComponent<Move>().moveSpeed = -MoveSpeed.moveSpeed;
            

        }
    }
}