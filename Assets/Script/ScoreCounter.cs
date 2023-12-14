using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextEnd;
    public void Start()
    {
        score = 0;
    }
    public void updateScore(int scoreadd)
    {
        score += scoreadd;
        scoreText.text = "Score : " + score;
        scoreTextEnd.text = "Score : " + score;
    }
}
