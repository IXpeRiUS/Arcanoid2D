using UnityEngine;
public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuUI;

    private void Start()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.onPause += TogglePauseMenu;
            //Debug.Log("Event PAUSE enabled");
        }
        else
        {
            Debug.LogError("GameManager instance is null. Ensure it is initialized before PauseMenuUI.");
        }
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
