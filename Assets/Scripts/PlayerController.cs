using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] BallLauncher ballLauncher;
    private float _movePlayer;
    private Vector3 _position;
    public float Speed;

    private readonly float MinX = -7.6f;  // Минимальная граница по X
    private readonly float MaxX = 4f;     // Максимальная граница по X

    void Update()
    {
        _movePlayer = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        // Получаем текущую позицию игрока
        _position = transform.position;

        // Изменяем X позицию с учетом ввода игрока
        _position.x += _movePlayer;

        // Ограничиваем позицию по X с помощью Mathf.Clamp
        _position.x = Mathf.Clamp(_position.x, MinX, MaxX);

        // Обновляем позицию объекта
        transform.position = _position;

        //запуск шара, если не запущен
        if (Input.GetKeyDown(KeyCode.Space))
        {
             ballLauncher.LaunchBall();
        }

        //меню пауза
        if (Input.GetButtonDown("Cancel"))
        {
            gameManager.TogglePause();
        }


    }
}
