using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles controlling the gameplay menu
public class GameplayMenuControll : MonoBehaviour
{
    // the buttons needed to be controlled
    public GameObject easy;
    public GameObject hard;
    public GameObject right;
    public GameObject left;
    public GameObject bobbingOn;
    public GameObject bobbingOff;


    void Start()
    {
        // enable or disable the buttons for dominant hand
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
        // enable or disable the buttons for the biome
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
        // enable or disable the buttons for difficulty
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


