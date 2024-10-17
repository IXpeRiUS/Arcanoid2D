using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class PauseButtonUI : MonoBehaviour
{
    [SerializeField] Sprite _pauseImage;
    [SerializeField] Sprite _resumeImage;
    //[SerializeField] PauseMenuUI _pauseMenu;
    [SerializeField] UnityEngine.UI.Image _pauseButtonImage;

    private void Start()
    {
        GameManager.Instance.onPause += SwitchButtonSprite;
    }
    public void SwitchButtonSprite(bool pause)  
    {
        if (pause)
        {
            _pauseButtonImage.sprite = _resumeImage;
            
        }
        else
        {
            _pauseButtonImage.sprite = _pauseImage;
            
        }
    }


}
