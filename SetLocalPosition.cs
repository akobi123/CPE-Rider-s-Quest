using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLocalPosition : MonoBehaviour
{
    public Vector3 relativePosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = relativePosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = relativePosition;
    }
}


