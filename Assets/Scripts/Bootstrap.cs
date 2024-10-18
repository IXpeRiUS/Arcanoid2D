using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] AudioManager _audioManager;


    private void Awake()
    {
        //здесь порядок инициализации классов
        _audioManager.Initialize();
    }
}
