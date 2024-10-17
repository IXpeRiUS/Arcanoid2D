using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class PauseButtonUI : MonoBehaviour
{
    [SerializeField] Sprite PauseImage;
    [SerializeField] Sprite ResumeImage;

    [SerializeField] UnityEngine.UI.Image buttonImage;

    private void Start()
    {
        GameManager.Instance.onPause += SwitchButtonSprite;
    }
    public void SwitchButtonSprite(bool pause) // Исправлено имя метода
    {
        if (pause)
        {
            buttonImage.sprite = ResumeImage;
        }
        else
        {
            buttonImage.sprite = PauseImage;
        }
    }


}
