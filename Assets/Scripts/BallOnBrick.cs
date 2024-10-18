using System;
using UnityEngine;



// красные просто уничтожить
//синие превращаются в красные или с трещиной

public class BallOnBrick : MonoBehaviour
{
    //[SerializeField] BrickSpriteList _sprite;
    //private BrickTag _brickTag;
    [SerializeField] BallSpeedController _ballSpeedController;
    private float _scoreMultiply = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        


        string tag = collision.gameObject.tag;
        SpriteRenderer spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
        switch (tag)
        {
            case "Black01Brick":
                Destroy(collision.gameObject);
                break;
            case "Blue01Brick":
                Destroy(collision.gameObject);
                break;
            case "Blue02Brick":
                Destroy(collision.gameObject);
                break;
            case "Blue03Brick":
                Destroy(collision.gameObject);
                break;
            case "Cyan01Brick":
                Destroy(collision.gameObject);
                break;
            case "Green01Brick":
                Destroy(collision.gameObject);
                break;
            case "Green02Brick":
                Destroy(collision.gameObject);
                break;
            case "Grey01Brick":
                Destroy(collision.gameObject);
                break;
            case "Orange01Brick":
                Destroy(collision.gameObject);
                break;
            case "Orange02Brick":
                Destroy(collision.gameObject);
                break;
            case "Pink01Brick":
                Destroy(collision.gameObject);
                break;
            case "Pink02Brick":
                Destroy(collision.gameObject);
                break;
            case "Pink03Brick":
                Destroy(collision.gameObject);
                break;
            case "Red01Brick":
                CalculateScore(_scoreMultiply);
                Destroy(collision.gameObject);
                break;
            case "Yellow01Brick":
                Destroy(collision.gameObject);
                break;
        }
    }

    private void CalculateScore(float scoreMultiply)
    {
        float speed = _ballSpeedController.GetCurrentSpeed();
        speed *= scoreMultiply;
        ScoreManager.Instance.AddScore((int)speed * 10); //умножить на 10 для красивого счета

    }





    // найти в словаре значение и переключить спрайт по следующему индексу!!!!!!
    //private void ChangeSprite(SpriteRenderer spriteRenderer)
    //{
    //    if (spriteRenderer != null && _sprite.sprites.Count > 0)
    //    {
    //        //spriteRenderer.sprite = _sprite.GetSprite(BrickTag.Black01Brick);
    //        if (Enum.TryParse(tag, out _brickTag))
    //        {
    //            int tagIndex = (int)_brickTag;
                
    //            if (tagIndex + 1 < _sprite.sprites.Count)
    //            {
    //                spriteRenderer.sprite = _sprite.sprites[tagIndex + 1];
    //            }
    //        }
    //    }

    //}
}
