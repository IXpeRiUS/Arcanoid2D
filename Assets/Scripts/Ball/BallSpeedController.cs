using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedController : MonoBehaviour
{
    [Header("Ball Speed")]
    public float MaxSpeed;
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
        else if (currentSpeed > MaxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * MaxSpeed;
        }
    }

    public float GetCurrentSpeed()
    {
        return _rb.velocity.magnitude;
    }
}
