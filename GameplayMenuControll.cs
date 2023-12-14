using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayMenuControll : MonoBehaviour
{
    public GameObject easy;
    public GameObject hard;
    public GameObject right;
    public GameObject left;
    public GameObject bobbingOn;
    public GameObject bobbingOff;


    void Start()
    {
        if (GameplaySettings.IsRightHanded == true)
        {
            right.SetActive(true);
            left.SetActive(false);
        }
        else
        {
            right.SetActive(false);
            left.SetActive(true);
        }
        if (GameplaySettings.IsBobbing == true)
        {
            bobbingOn.SetActive(true);
            bobbingOff.SetActive(false);
        }
        else
        {
            bobbingOn.SetActive(false);
            bobbingOff.SetActive(true);
        }
        if (GameplaySettings.IsEasy == true)
        {
            easy.SetActive(true);
            hard.SetActive(false);
        }
        else
        {
            easy.SetActive(false);
            hard.SetActive(true);
        }
    }
}


