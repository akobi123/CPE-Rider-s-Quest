using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// this script handles changing of the scenes
public class SceneChanger : MonoBehaviour
{
    // Switches to a specified scene
    public void switchScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
