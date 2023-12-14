using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowCollision : MonoBehaviour
{
    // Start is called before the first frame update
    bool hit = false;

    private Rigidbody rBody; //or public Rigidbody rBody; 
    private BoxCollider bCollider;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        bCollider = GetComponent<BoxCollider>();
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Target1")
        {
            Debug.Log("Nice Shot");
            ScoreDisplay.instance.addScore(3);
        }
        else if(collision.gameObject.name == "Target2")
        {
            Debug.Log("Good shot");
            ScoreDisplay.instance.addScore(2);
        }
        else if (collision.gameObject.name == "Target3")
        {
            Debug.Log("Shot");
            ScoreDisplay.instance.addScore(1);
        }
        

        if (!hit)
        {
            ArrowStick(collision);
            hit = true;
        }
        try
        {
            destroyThis(collision.gameObject.transform.parent.gameObject);

        }
        catch { }
    }
    

    void ArrowStick(Collider col)
    {

        // move the arrow deep inside the enemy or whatever it sticks to
        //col.transform.Translate(depth * -Vector2.right);
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
            obj.AddComponent<Rigidbody>();
            //obj.AddComponent<DestroyTarget>();
            obj.GetComponent<Move>().moveSpeed = 0;
            Destroy(obj.GetComponent<MoveTargets>());
        }
    }
}
