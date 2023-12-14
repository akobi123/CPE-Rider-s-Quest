using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDifficutyController : MonoBehaviour
{
    public GameObject easyObject;
    public GameObject[] hardObject;
    private AudioSource audioSource;

    void Start()
    {
        if (GameplaySettings.IsEasy == true)
        {
            foreach (GameObject audioObject in hardObject)
            {
                audioObject.SetActive(false);
            }
            easyObject.SetActive(true);

            audioSource = easyObject.GetComponent<AudioSource>();
            audioSource.Play();

        }
        else
        {
            easyObject.SetActive(false);

            int rand = Random.Range(0, 2);

            hardObject[rand].SetActive(true);
            hardObject[1-rand].SetActive(false);

            audioSource = hardObject[rand].GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
}
