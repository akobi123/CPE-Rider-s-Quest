using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControll : MonoBehaviour
{
    public GameObject leftBow;
    public GameObject rightBow;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject leftPause;
    public GameObject rightPause;


    void Start()
    {
        if (GameplaySettings.IsRightHanded == true)
        {
            leftBow.SetActive(true);
            rightArrow.SetActive(true);
            rightPause.SetActive(true);
            rightBow.SetActive(false);
            leftArrow.SetActive(false);
            leftPause.SetActive(false);
        }
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
