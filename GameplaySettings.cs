using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySettings : MonoBehaviour
{
    public static bool IsEasy = true;
    public static bool IsRightHanded = true;
    public static bool IsBobbing = true;

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
