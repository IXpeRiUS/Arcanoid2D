using Unity.VisualScripting;
using UnityEngine;
public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuUI;

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
        // Включить меню паузы, если игра на паузе, и выключить, если пауза отключена
        if (pause)
        {
            _pauseMenuUI.SetActive(true); // Включить меню паузы
            //Debug.Log("PauseON");
        }
        else
        {
            _pauseMenuUI.SetActive(false); // Выключить меню паузы
            //Debug.Log("PauseOFF");
        }
    }
}
