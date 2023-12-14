using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles changing the dominant hand based on the setting
public class HandControll : MonoBehaviour
{
    // objects to change
    public GameObject leftBow;
    public GameObject rightBow;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject leftPause;
    public GameObject rightPause;


    void Start()
    {
        // if right handed
        if (GameplaySettings.IsRightHanded == true)
        {
            leftBow.SetActive(true);
            rightArrow.SetActive(true);
            rightPause.SetActive(true);
            rightBow.SetActive(false);
            leftArrow.SetActive(false);
            leftPause.SetActive(false);
        }
        // if left handed
        else
        {
            leftBow.SetActive(false);
            rightArrow.SetActive(false);
            rightPause.SetActive(false);
            rightBow.SetActive(true);
            leftArrow.SetActive(true);
            leftPause.SetActive(true);
        }
    }
}
