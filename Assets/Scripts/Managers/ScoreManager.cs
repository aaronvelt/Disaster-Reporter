using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public float score;

    private void Awake()
    {
        instance = this;
    }

    public void IncreaseScore(float points)
    {
        score += points;
        scoreText1.text = "" + (int)score;
        scoreText2.text = "" + (int)score;
        scoreText3.text = "" + (int)score;
    }
    
    
}
