using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script spawns terrain so that it creates illusion of moving forward
public class TerrainSpawner : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public Terrain terr; // Attach terrain to this in unity
    private Terrain[] terrain = new Terrain[2]; //create array of 2 terrains to rotaate them form on to other
    void Start()
    {
        terrain[0] = Instantiate(terr, new Vector3(-500f, 0f, -500f), Quaternion.identity); // create this as the player in center
        terrain[1] = Instantiate(terr, new Vector3(-500f, 0f, 500f), Quaternion.identity); // create this just after the other
        // attach the terrain to the object on which the script is, so that the terrain can move
        terrain[0].transform.parent = transform;
        terrain[1].transform.parent = transform;

    }

    void Update()
    {
        // update offset
        float offset = -MoveSpeed.moveSpeed * Time.deltaTime;
        //move both terrains by offset
        terrain[0].transform.Translate(new Vector3(0f, 0f, offset));
        terrain[1].transform.Translate(new Vector3(0f, 0f, offset));

        //if the player is in the middle of the secdond terrain
        if (terrain[1].transform.position.z <= -500)
        {
            //destroy the terrains
            Destroy(terrain[1].gameObject);
            Destroy(terrain[0].gameObject);
            // creatge new ones in the starting location
            terrain[0] = Instantiate(terr, new Vector3(-500f, 0f, -500f), Quaternion.identity);
            terrain[1] = Instantiate(terr, new Vector3(-500f, 0f, 500f), Quaternion.identity);
            // attach the terrain to the object on which the script is, so that the terrain can move
            terrain[0].transform.parent = transform;
            terrain[1].transform.parent = transform;
        }
    }
}
