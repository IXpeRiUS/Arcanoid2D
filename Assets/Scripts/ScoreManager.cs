using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public event Action<int> OnScoreChanged;
    public event Action<int> OnBestScoreChanged;

    private int _score;
    private int _bestScore;

    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Позволяет объекту пережить загрузку новой сцены
        }
        else
        {
            Destroy(gameObject); // Уничтожаем дублирующий экземпляр
        }

    }

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }
    public void AddScore(int score)
    {
        _score += score;
        OnScoreChanged?.Invoke(_score);
        
        AddBestScore(_score);
        
        //Debug.Log($"Current: {_currentScore }" );
    }

    private void AddBestScore(int score)
    {
        if (_bestScore < score)
        {
            _bestScore = score;
            SaveBestScore(_bestScore);
        }
        OnBestScoreChanged?.Invoke(_bestScore);
    }

    public void SaveScore(int score)
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
        Debug.Log($"{score} saved.");
    }


    private void SaveBestScore(int bestScore)
    {
        PlayerPrefs.SetInt("BestScore", bestScore);
        PlayerPrefs.Save(); // Сохранение значений PlayerPrefs
        Debug.Log($"{bestScore} saved.");
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetBestScore()
    {
        return _bestScore;
    }
}
