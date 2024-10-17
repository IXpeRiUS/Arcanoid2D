using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlickerFrame : MonoBehaviour
{
    [SerializeField] GameObject _mainFrameOff;
    [SerializeField] GameObject _mainFrameOn;

    //private SpriteRenderer _spriteRenderer;
    private float _minFlickerTime = 0.1f;  // Минимальное время между переключениями
    private float _maxFlickerTime = 1f;    // Максимальное время между переключениями

    private void Start()
    {
        //_spriteRenderer = GetComponent<SpriteRenderer>();
        //начать случайное мерцание
        InvokeFlicker();
    }


    private void InvokeFlicker()
    {
        //установка случайного времени до следующего мерцания
        float randomTime = Random.Range(_minFlickerTime, _maxFlickerTime);

        //переключение спрайта
        ToggleFrame();

        //рекурсивно вызвать метод снова через случайный промежуток времени
        Invoke(nameof(InvokeFlicker), randomTime);
    }

    private void ToggleFrame()
    {
        //если включено, то выключить, иначе включить
        if (_mainFrameOn.activeSelf)
        {
            _mainFrameOn.SetActive(false);
            _mainFrameOff.SetActive(true);

        }
        else
        {
            _mainFrameOn.SetActive(true);
            _mainFrameOff.SetActive(false);

        }
    }
}
