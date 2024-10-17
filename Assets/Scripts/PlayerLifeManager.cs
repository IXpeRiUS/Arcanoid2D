using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeManager : MonoBehaviour
{
    private int _playersLife = 3;
    public static PlayerLifeManager Instance;
    public Action<int> OnPlayerLife;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);// Позволяет объекту пережить загрузку новой сцены
        }
        else
        {
            Destroy(gameObject); // Уничтожаем дублирующий экземпляр
        }
    }


    public int GetLife()
    {
        return _playersLife;
    }
    public void AddLive(int life)
    {
        _playersLife += life; // Увеличиваем количество жизней
        _playersLife = Mathf.Clamp(_playersLife, 0, 5); // Ограничиваем жизнями от 0 до 5
        OnPlayerLife?.Invoke(_playersLife);
    }


    public void RemoveLife(int life)
    {
        _playersLife -= life;
        OnPlayerLife?.Invoke(_playersLife);
        if (_playersLife < 0)
        {
            //TODO GAMEOVER
        }
    }
}
