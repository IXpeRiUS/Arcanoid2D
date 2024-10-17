using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedLimiter : MonoBehaviour
{
    [Header("Ball Speed")]
    public float Speed;
    public float MinSpeed;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Текущая скорость
        float currentSpeed = _rb.velocity.magnitude;
        // Если скорость меньше минимальной, установим минимальную скорость
        if (currentSpeed < MinSpeed && currentSpeed > 0)
        {
            _rb.velocity = _rb.velocity.normalized * MinSpeed;
        }
        // Если скорость больше максимальной, установим максимальную скорость
        else if (currentSpeed > Speed)
        {
            _rb.velocity = _rb.velocity.normalized * Speed;
        }
    }
}
