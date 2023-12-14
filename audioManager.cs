using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles changing the main volume of the game
public class audioManager : MonoBehaviour
{
    void Update()
    {
        // change the volume from the audio listener to affect all audio
        AudioListener.volume = ((float)(transform.localPosition.x)+(float)(1.5))/(float)(3.0);
    }
}
