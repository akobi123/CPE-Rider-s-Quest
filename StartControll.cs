using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this scene handles changing the button on the main menu
// based on the biome setting
public class StartControll : MonoBehaviour
{
    // the buttons
    public GameObject forest;
    public GameObject desert;

    // function to change the buttons
    public void changeBiome()
    {
        // if forest is picked set its button as active
        // and the other one as inactive
        if (GameplaySettings.IsBobbing == true)
        {
            forest.SetActive(true);
            desert.SetActive(false);
        }
        // if desert is picked set its button as active
        // and the other one as inactive
        else
        {
            forest.SetActive(false);
            desert.SetActive(true);
        }
    }
}
