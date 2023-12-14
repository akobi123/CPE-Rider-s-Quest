using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerList : MonoBehaviour
{
    public GameObject[] audioObjects;

    void Update()
    {
        foreach (GameObject audioObject in audioObjects)
        {
            AudioSource audioSource = audioObject.GetComponent<AudioSource>();

            audioSource.volume = ((float)(transform.localPosition.x) + (float)(1.5)) / (float)(3.0);
        }
    }
}


