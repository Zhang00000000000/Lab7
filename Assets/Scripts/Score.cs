﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Obstacle")
        {
            score += 1;
        }
    }
}