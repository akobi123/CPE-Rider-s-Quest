using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public float moveSpeed = -1f; // Speed at which the object will move
    public bool isTree = false;
    private void Start()
    {
        if (GameplaySettings.IsEasy == false && isTree == false)
        {
            int r = Random.Range(0, 100);
            this.AddComponent<MoveTargets>();
            if (r >= 80)
            {
                this.GetComponent<MoveTargets>().difficulty = 1;
            }
            else if (r >= 55)
            {
                this.GetComponent<MoveTargets>().difficulty = 2;
            }
            else if (r >= 30)
            {
                this.GetComponent<MoveTargets>().difficulty = 3;
            }
        }

    }
    void Update()
    {
        if (gameObject.transform.position.z < -25 && isTree == false)
        {
            Destroy(gameObject);
            HealthController.instance.kill();
        }
        if (gameObject.transform.position.y < -2)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        }
    }

}
