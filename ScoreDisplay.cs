using Oculus.Platform;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public static ScoreDisplay instance;
    int score = 0;
    public Text timeText;
    float starttime;
    public float time;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        starttime = Time.time;
    }
    private void Update()
    {
        time = (Time.time - starttime);
        timeText.text = "Time: " + time.ToString("n2"); //set precison to 2 decimal plave
    }

    // Update is called once per frame
    public void addScore(int i)
    {
        score += i * (int)Math.Round(1 + time * 0.01f); 
        scoreText.text = "Score: " + score.ToString();
    }
}
