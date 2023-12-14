using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

//This script moves the objects towarsd sthe player. Also can change movemnt for targets using MoveTarget script
public class Move : MonoBehaviour
{
    public float moveSpeed = -1f; // Speed at which the object will move
    public bool isTree = false;

    private void Start()
    {
        // add MoveTarget script if the object is not a tree and the game is in hard mode
        if (GameplaySettings.IsEasy == false && isTree == false)
        {
            // get random number from 0 to 100
            int r = Random.Range(0, 100);
            this.AddComponent<MoveTargets>();
            // choose type of movemnet based on random number
            if (r >= 80)
            {
                //move on circles
                this.GetComponent<MoveTargets>().difficulty = 1;
            }
            else if (r >= 55)
            {
                // move horizontally 
                this.GetComponent<MoveTargets>().difficulty = 2;
            }
            else if (r >= 30)
            {
                //move vertically
                this.GetComponent<MoveTargets>().difficulty = 3;
            }
        }

    }

    private void Update()
    {   
        // if the object is too far back
        if (gameObject.transform.position.z < -25)
        {
            // if the object is a target decrease health by one
            if(isTree == false){
                HealthController.instance.kill();
            }
            //destroy
            Destroy(gameObject);
        }
        // if the object falls below the ground destory it (this happens when a target gets hit)
        else if (gameObject.transform.position.y < -2)
        {
            Destroy(gameObject);
        }

        else
        {   
            //move the object towards player
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

}
