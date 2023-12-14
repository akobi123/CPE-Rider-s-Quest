using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void open(GameObject menu)
    {
        menu.SetActive( true );
    }

    public void close(GameObject menu)
    {
        menu.SetActive( false );
    }
}
