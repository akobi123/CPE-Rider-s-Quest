using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles pausing and resuming the game
public class PauseControll : MonoBehaviour
{
    // pause the game
    public void pause()
    {
        Time.timeScale = 0f;
    }

    // resume the game
    public void resume()
    {
        Time.timeScale = 1f;
    }
}


