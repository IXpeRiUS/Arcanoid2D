using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLose : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] BallLauncher _ballLauncher;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BottomWall"))
        {
            PlayerLifeManager.Instance.RemoveLife(1);
            _rb.velocity = Vector3.zero;
            transform.position = new Vector3(0,0, 0); //записать трансформ игрока!!!
            _ballLauncher.isForsed = false;
        }
    }
}
