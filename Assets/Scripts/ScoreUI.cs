using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;


    private void Start()
    {
        ScoreManager.Instance.OnScoreChanged += UpdateScoreUI;
        ScoreManager.Instance.OnBestScoreChanged += UpdateBestScoreUI;

    }
    private void UpdateScoreUI(int score)
    {
        scoreText.text = score.ToString();
    }

    private void UpdateBestScoreUI(int bestScore)
    {
       bestScoreText.text = bestScore.ToString();
    }
}
