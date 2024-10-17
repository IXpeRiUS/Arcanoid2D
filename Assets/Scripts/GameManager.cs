using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private PauseButtonUI pauseButtonUI;
    public bool isPause = false;

    public Action<bool> onPause;

    private void Awake()
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
        StartCoroutine(ResumeGameSmoothly());
    }

    private IEnumerator ResumeGameSmoothly()
    {
        float duration = 0.3f;
        float currentTime = 0f;
        float initialTimeScale = Time.timeScale;

        while (currentTime < duration)
        {
            currentTime += Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Lerp(initialTimeScale, 1f, currentTime / duration);
            yield return null;
        }

        Time.timeScale = 1f;
        isPause = false;
        onPause?.Invoke(isPause);
    }
}
