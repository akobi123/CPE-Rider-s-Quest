using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowCollision : MonoBehaviour
{
    // variabels
    private Rigidbody rBody; 
    private BoxCollider bCollider;
    
    void Start()
    {
        rBody = GetComponent<Rigidbody>(); //assign rigidbody of the object the script is attached to
        bCollider = GetComponent<BoxCollider>(); //assign the box collider of the object the script is attached to
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Target1")
        {
            //Debug.Log("Nice Shot");
            ScoreDisplay.instance.addScore(3);
        }
        else if(collision.gameObject.name == "Target2")
        {
            //Debug.Log("Good shot");
            ScoreDisplay.instance.addScore(2);
        }
        else if (collision.gameObject.name == "Target3")
        {
            //Debug.Log("Shot");
            ScoreDisplay.instance.addScore(1);
        }
        // stick the arrow to the taget
        ArrowStick(collision);
        // stop the target, make it drop, and destory once it reaches ground
        destroyThis(collision.gameObject.transform.parent.gameObject);
    }
    

    void ArrowStick(Collider col)
    {
        // Make the arrow a child of the thing it's stuck to
        transform.parent = col.transform;

        //transform.Rotate(new Vector3(90, 0, 0));
        
        //Destroy the arrow's rigidbody2D and collider2D
        Destroy(rBody);
        Destroy(bCollider);
    }

    void destroyThis(GameObject obj)
    {
        //Debug.Log(obj.name);
        if(obj.name == "TargetController 1(Clone)")
        {
            // add rigidbody to the whole thing so it start falling
            obj.AddComponent<Rigidbody>();
            // set speed to 0 so it stops moving towards the player
            obj.GetComponent<Move>().moveSpeed = 0;
            // destroy the vertcal, horizontal, or cirular motion script
            Destroy(obj.GetComponent<MoveTargets>());

            //the object will get destoryed in the Move scipt, when it falls below the ground
        }
    }
}
