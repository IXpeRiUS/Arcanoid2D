using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoundButtonUI : MonoBehaviour
{
    [SerializeField] Sprite _soundOn;
    [SerializeField] Sprite _soundOff;
    [SerializeField] UnityEngine.UI.Image _soundButtonImage;
    [SerializeField] TextMeshProUGUI _text;



    private void OnEnable()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.onSound += SwitchAudioButtonSprite;
        }
        else
        {
            Debug.Log("AudioManager instance is null in OnEnable");
        }
    }

    private void OnDisable()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.onSound -= SwitchAudioButtonSprite;
        }
        else
        {
            //Debug.Log("AudioManager instance is null in OnDisable");
        }
    }

    public void SwitchAudioButtonSprite(bool sound)
    {
        if (sound)
        {
            _soundButtonImage.sprite = _soundOff;
            _text.text = "Звук вкл.";

        }
        else
        {
            _soundButtonImage.sprite = _soundOn;
            _text.text = "Звук выкл.";
        }
    }
}
