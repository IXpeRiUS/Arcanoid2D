using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isForsed = false; //шар в состоянии не запущен
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //запуск шара находящегося в состоянии покоя
    public void LaunchBall()
    {
        rb.AddForce(new Vector3(Random.Range(-3f, 2f), Random.Range(1f, 2f)));
        isForsed = true;//шар в состоянии запущен
    }
}
