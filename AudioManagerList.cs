using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles changing the volume of audio based on the scrollers
public class AudioManagerList : MonoBehaviour
{
    // the list of audio game objects to be controlled
    public GameObject[] audioObjects;

    void Update()
    {
        // for each audio object
        foreach (GameObject audioObject in audioObjects)
        {
            // get the audio source component
            AudioSource audioSource = audioObject.GetComponent<AudioSource>();

            // change the volume based on the local position of the scroller
            audioSource.volume = ((float)(transform.localPosition.x) + (float)(1.5)) / (float)(3.0);
        }
    }
}


