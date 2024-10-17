using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScoreUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI _bestScoreText;


    private void Start()
    {
        ScoreManager.Instance.OnScoreChanged += UpdateScoreUI;
        ScoreManager.Instance.OnBestScoreChanged += UpdateBestScoreUI;
        UpdateScoreUI(ScoreManager.Instance.GetScore());
        UpdateBestScoreUI(ScoreManager.Instance.GetBestScore());
    }
    private void UpdateScoreUI(int score)
    {
        _scoreText.text = score.ToString();
    }

    private void UpdateBestScoreUI(int bestScore)
    {
       _bestScoreText.text = bestScore.ToString();
    }
}
