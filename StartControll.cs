using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControll : MonoBehaviour
{
    public GameObject forest;
    public GameObject desert;
    public void changeBiome()
    {
        if (GameplaySettings.IsBobbing == true)
        {
            forest.SetActive(true);
            desert.SetActive(false);
        }
        else
        {
            forest.SetActive(false);
            desert.SetActive(true);
        }
    }
}
