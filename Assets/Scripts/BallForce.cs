using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void AddForceBall()
    {
        rb.AddForce(new Vector3(Random.Range(-3f, 2f), Random.Range(1f, 2f)));
    }
}
