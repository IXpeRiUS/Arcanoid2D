using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public event Action<int> OnScoreChanged;
    public event Action<int> OnBestScoreChanged;

    private int _currentScore;
    private int _bestScore;

    private void Awake()
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
        _currentScore += score;
        OnScoreChanged?.Invoke(_currentScore);
        
        AddBestScore(_currentScore);
        
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

    private void SaveBestScore(int bestScore)
    {
        PlayerPrefs.SetInt("BestScore", bestScore);
        PlayerPrefs.Save(); // Сохранение значений PlayerPrefs
        Debug.Log($"{bestScore} saved.");
    }
}
