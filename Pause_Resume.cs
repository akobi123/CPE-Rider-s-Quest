using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Resume : MonoBehaviour
{
    // Start is called before the first frame update
    public void pause()
    {
        Time.timeScale = 0f;
    }

    public void resume()
    {
        Time.timeScale = 1f;
    }
}
