using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public Terrain terr;
    private Terrain[] terrain = new Terrain[2];
    void Start()
    {
        terrain[0] = Instantiate(terr, new Vector3(-500f, 0f, -500f), Quaternion.identity);
        terrain[1] = Instantiate(terr, new Vector3(-500f, 0f, 500f), Quaternion.identity);

        terrain[0].transform.parent = transform;
        terrain[1].transform.parent = transform;

    }

    void Update()
    {
        float offset = -MoveSpeed.moveSpeed * Time.deltaTime;
        terrain[0].transform.Translate(new Vector3(0f, 0f, offset));
        terrain[1].transform.Translate(new Vector3(0f, 0f, offset));

        if (terrain[1].transform.position.z <= -500)
        {
            Destroy(terrain[1].gameObject);
            Destroy(terrain[0].gameObject);
            terrain[0] = Instantiate(terr, new Vector3(-500f, 0f, -500f), Quaternion.identity);
            terrain[1] = Instantiate(terr, new Vector3(-500f, 0f, 500f), Quaternion.identity);

            terrain[0].transform.parent = transform;
            terrain[1].transform.parent = transform;
        }
    }
}
