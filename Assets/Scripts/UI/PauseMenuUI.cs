using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuUI;
    [SerializeField] GameObject _pauseButton;
    [SerializeField] private GameObject _soundButton;
    [SerializeField] GameObject _restartGameButton;
    [SerializeField] GameObject _resumeGameButton;

   

    private void OnEnable()
    {
        GameManager.Instance.onPause += TogglePauseMenu;
    }

    private void OnDisable()
    {
        GameManager.Instance.onPause -= TogglePauseMenu;
    }

    private void TogglePauseMenu(bool pause)
    {
        _pauseMenuUI.SetActive(pause); // Включить меню паузы
        _pauseButton.SetActive(!pause); // Отключить кнопку на боковой панели игры для красоты
        _soundButton.SetActive(!pause); // Отключить кнопку звука
        if (GameManager.Instance.isGameOver) 
        {
            //игра окончена активировать кнопку Рестарт 
            _restartGameButton.SetActive(true);
            _resumeGameButton.SetActive(false);
            GameManager.Instance.onGameOver.Invoke(pause);
        }
        else
        {
            //игра не окончена активировать кнопку Вернуться в игру
            _restartGameButton.SetActive(false);
            _resumeGameButton.SetActive(true);
        }
    }


}
