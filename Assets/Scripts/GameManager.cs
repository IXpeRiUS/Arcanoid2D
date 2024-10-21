using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private PauseButtonUI pauseButtonUI;
    [SerializeField] GameOverMenuUI _overMenuUI;
    public bool isPause = false;
    public bool isGameOver = false;

    public Action<bool> onPause;
    public Action<bool> onGameOver;

    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TogglePause()
    {
        _overMenuUI.GameOverText(isGameOver);
        if (!isPause)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        isPause = true;
        onPause?.Invoke(isPause);
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        isPause = false;
        onPause?.Invoke(isPause);
    }
}
