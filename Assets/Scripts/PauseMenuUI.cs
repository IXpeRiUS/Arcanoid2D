using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuUI;
    [SerializeField] GameObject _pauseButton;
    [SerializeField] private GameObject _soundButton;
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
    }


}
