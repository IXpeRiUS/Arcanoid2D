using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private bool isSoundOn = true;
    public Action<bool> onSound;

    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Сохранение объекта между сценами
        }
        else
        {
            Destroy(gameObject); // Уничтожение дубликатов
        }
    }



    private void UpdateAudioListener()
    {
        AudioListener.pause = !isSoundOn; // Логическое отрицание для контроля паузы
    }

    public void ToggleAudio()
    {
        if (isSoundOn)
        {
            onSound?.Invoke(true);
        }
        else
        {
            onSound?.Invoke(false);
        }
        isSoundOn = !isSoundOn; // Переключение состояния звука
        UpdateAudioListener();  // Обновление состояния AudioListener
    }
}
