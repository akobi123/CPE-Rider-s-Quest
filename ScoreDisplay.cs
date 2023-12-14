using Oculus.Platform;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

// This script displays score and time on canvas, also keeps track of score.
public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText; // drag and drop text object where the score should show
    public Text timeText; // drag and drop text object where the time should show
    public static ScoreDisplay instance; // instance of this class

    private float time;
    private float starttime;
    private int score = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        //create an instance so other scripts can access this one
        instance = this;
    }
    void Start()
    {
        // Display score
        scoreText.text = "Score: " + score.ToString();
        // initialize stattime
        starttime = Time.time;
    }
    private void Update()
    {
        // update time
        time = (Time.time - starttime);
        //display trime with 2 decimal precision
        timeText.text = "Time: " + time.ToString("n2"); //set precison to 2 decimal plave
    }

    public void addScore(int i)
    {
        //increse score, using linear time dependent equation
        score += i * (int)Math.Round(1 + time * 0.02f); 
        //display score
        scoreText.text = "Score: " + score.ToString();
    }
}
