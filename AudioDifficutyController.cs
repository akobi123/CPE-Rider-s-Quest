using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles changing the music based on the difficulty
public class AudioDifficutyController : MonoBehaviour
{
    public GameObject easyObject; // music for easy difficulty
    public GameObject[] hardObject; // array for music for had difficulty
    private AudioSource audioSource; // temporary variable used in the script

    void Start()
    {
        // if the difficulty is easy
        if (GameplaySettings.IsEasy == true)
        {
            // turn off hard music
            foreach (GameObject audioObject in hardObject)
            {
                audioObject.SetActive(false);
            }
            // turn on easy music
            easyObject.SetActive(true);

            // play the easy music
            audioSource = easyObject.GetComponent<AudioSource>();
            audioSource.Play();

        }
        // if the difficulty is hard
        else
        {
            // turn off easy music
            easyObject.SetActive(false);

            // pick a random hard music to play
            int rand = Random.Range(0, 2);

            // turn on the chosen hard music and turn off the other
            hardObject[rand].SetActive(true);
            hardObject[1-rand].SetActive(false);

            // play the chosen hard music
            audioSource = hardObject[rand].GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
}
