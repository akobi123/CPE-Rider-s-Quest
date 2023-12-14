using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles saving the gameplay settings
public class GameplaySettings : MonoBehaviour
{
    // static variables for the settings to be accessable from other scripts
    public static bool IsEasy = true;
    public static bool IsRightHanded = true;
    public static bool IsBobbing = true;

    // functions to change each setting
    public void changeDifficulty()
    {
        IsEasy = !IsEasy;
    }
    public void changeHand()
    {
        IsRightHanded = !IsRightHanded;
    }
    public void changeBobbing()
    {
        IsBobbing = !IsBobbing;
    }
}
