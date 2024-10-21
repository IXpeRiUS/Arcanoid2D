using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPositionLaunch : MonoBehaviour
{
    [SerializeField] Transform _playerPosition;
    private Vector2 _position;
    [SerializeField] BallLauncher _launcher;

    private void Update()
    {
        if (_launcher.isForsed == false)
        {
            _position = _playerPosition.position;
            _position.y += 0.5f;
            transform.position = _position;
        }
    }

}
