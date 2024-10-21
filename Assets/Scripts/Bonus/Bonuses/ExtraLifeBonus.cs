using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLifeBonus : MonoBehaviour, IBonus
{
    private readonly int _oneLife = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            ApplyBonus();
            Destroy(gameObject);
        }
        if (collision.CompareTag("BottomWall"))
        {
            Destroy(gameObject);
        }
    }

    public void ApplyBonus()
    {
        PlayerLifeManager.Instance.AddLive(_oneLife);
    }

}
