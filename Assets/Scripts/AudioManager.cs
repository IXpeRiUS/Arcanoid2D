using UnityEngine;

public class AudioManager : MonoBehaviour
{

    private bool isSoundOn = true;



    private void UpdateAudioListener()
    {
        AudioListener.pause = !isSoundOn; // Логическое отрицание для контроля паузы
    }

    public void SoundSwitch()
    {
        isSoundOn = !isSoundOn; // Переключение состояния звука
        UpdateAudioListener();  // Обновление состояния AudioListener
    }
}
