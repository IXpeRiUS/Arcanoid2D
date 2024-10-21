using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverMenuUI : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] TextMeshProUGUI _gameOverText;
    //TODO GAMEOVER
    //поставить на паузу
    //заенить лейбл на проигрыш
    //заменить кнопку плей на рестарт
    //сделать рестарт игры из открытых сцен\\

    private void OnEnable()
    {
        _gameManager.onGameOver += GameOverText;
    }
    private void OnDisable()
    {
        _gameManager.onGameOver -= GameOverText;
    }

    public void GameOver()
    {
        _gameManager.isGameOver = true;
        _gameManager.onGameOver?.Invoke(_gameManager.isGameOver);
        _gameManager.TogglePause();
    }

    public void GameOverText(bool gameOver)
    {
        if (gameOver)
        {
           VertexGradient gradient = new VertexGradient(
               Color.red,
               Color.red,
               Color.white,
               Color.white
               );
            _gameOverText.colorGradient = gradient;
            _gameOverText.text = "Игра окончена";
        }
        else
        {
            _gameOverText.text = "Пауза";
        }
    }
}
