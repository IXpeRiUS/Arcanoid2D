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
        if (ScoreManager.Instance != null)
        {
            UpdateScoreUI(ScoreManager.Instance.GetScore());
            UpdateBestScoreUI(ScoreManager.Instance.GetBestScore());
        }
        else
        {
            Debug.LogError("ScoreManager instance is null in Start");
        }
    }

    private void OnEnable()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.OnScoreChanged += UpdateScoreUI;
            ScoreManager.Instance.OnBestScoreChanged += UpdateBestScoreUI;
        }
        else
        {
            Debug.LogError("ScoreManager instance is null in OnEnable");
        }
    }

    private void OnDisable()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.OnScoreChanged -= UpdateScoreUI;
            ScoreManager.Instance.OnBestScoreChanged -= UpdateBestScoreUI;
        }
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
