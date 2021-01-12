﻿
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textscore;
    [Header("分數")]
    public int score;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "plant")
        { 
            AddScore();
        }
    }


    private void AddScore()
    {
        score += 3;
        textscore.text="SCORE "+score;
    }



}
