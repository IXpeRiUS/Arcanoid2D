using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] AudioManager _audioManager;
    [SerializeField] GameManager _gameManager;

    private void Awake()
    {
        //здесь порядок инициализации классов
        _audioManager.Initialize();
        _gameManager.Initialize();
    }
}
