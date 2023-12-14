using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles enabling and disabling an object
public class MenuManager : MonoBehaviour
{
    // enable object
    public void open(GameObject menu)
    {
        menu.SetActive( true );
    }

    // disable object
    public void close(GameObject menu)
    {
        menu.SetActive( false );
    }
}
