using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] AudioManager _audioManager;
    [SerializeField] GameManager _gameManager;
    [SerializeField] PlayerLifeManager _playerLifeManager;

    private void Awake()
    {
        //здесь порядок инициализации классов
        _audioManager.Initialize();
        _gameManager.Initialize();
        _playerLifeManager.Initialize();
    }
}
