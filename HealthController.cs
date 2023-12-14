using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Image[] alive; // drag and drop the alive heart image form canvas
    public Image[] dead; // draga nd drop dead heart image form canvas
    public static HealthController instance;
    public GameObject pause;
    public GameObject gameOver;
    public GameObject horse;
    private bool aliveCheck = false;

    
    // Awake is done before Start, and the instance makes sure that there is only one copy of the script.
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        //make sure the alives are turned on and dead turned off in the begining
        for(int i = 0; i < alive.Length; i++)
        {
            alive[i].enabled = true;
            dead[i].enabled = false;
        }
    }


    public void kill()
    {
        // go over the whole array
        for (int i = alive.Length-1; i >= 0 ; i--)
        {
            //if the alive is turned on, turn it off and turn on the dead image on it's place
            //The hearts will follow their index in the array (first gets turned off first)
            if(alive[i].enabled == true)
            {
                // check if the player ran out of lives
                if (i!=0)
                {
                    aliveCheck = true;
                }
                dead[i].enabled = true;
                alive[i].enabled = false;
                break;
            }
        }

        //check if the player is dead
        if (aliveCheck == false)
        {    
            //go to game over screen, stop everything else
            pause.SetActive(false);
            gameOver.SetActive(true);
            horse.SetActive(false);
            Time.timeScale = 0f;
        }
        
    }
}
