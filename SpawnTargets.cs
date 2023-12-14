using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Spawn targets randomly left and right, without spawning them directly in front of the player.
public class SpawnTargets : MonoBehaviour
{
    public GameObject targetPrefab; // Reference to the target prefab
    public float delay = 1f; // Number of targets to spawn
    public float moveSpeed = 1f; // Speed at which targets move
    public float spawnArea = 1f; // Range of random spawn area
    
    private float timeToSpawn;

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

            // choose where to spwan the target: left or right
            int sign = Random.Range(0, 100);
            //Debug.Log(sign);
            if (sign % 2 == 0) sign = 1;
            else sign = -1;

            // creatre random position with x coordinate as left or right of the player with distance random form spawnArea to 5*spawnArea
            // y coordinate - random form 2 to 3*spawnarea, 25 as z coordinate 
            Vector3 randomPosition = new Vector3(Random.Range(spawnArea, spawnArea * 5f) * sign, Random.Range(2f, 3f*spawnArea), 25f);

            //create the target at random posiiton
            GameObject target = Instantiate(targetPrefab, randomPosition, Quaternion.identity);
            //add move script and set speed to speed form MoveSpeed class
            target.AddComponent<Move>();
            target.GetComponent<Move>().moveSpeed = -MoveSpeed.moveSpeed;
        }
    }
}
