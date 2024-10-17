using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButtonUI : MonoBehaviour
{
    [SerializeField] Sprite _soundOn;
    [SerializeField] Sprite _soundOff;
    [SerializeField] UnityEngine.UI.Image _soundButtonImage;


    private void Start()
    {
        AudioManager.Instance.onSound += SwitchAudioButtonSprite;
    }

    public void SwitchAudioButtonSprite(bool sound)
    {
        if (sound)
        {
            _soundButtonImage.sprite = _soundOff;
        }
        else
        {
            _soundButtonImage.sprite = _soundOn;
        }
    }
}
