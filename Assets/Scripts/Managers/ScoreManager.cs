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
    public MeshRenderer wallMeshRenderer;
    public Material hiredMat;
    public Material firedMat;
    
    public float score;
    public float hiredCondition;

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

    public void GetScoreResult()
    {
        if (score >= hiredCondition)
        {
            wallMeshRenderer.material = hiredMat;
        }
        else
        {
            wallMeshRenderer.material = firedMat;
        }
    }
    
    
}
