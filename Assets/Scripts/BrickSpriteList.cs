using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BrickTag
{
    Black01Brick,
    Blue01Brick,
    Blue02Brick,
    Blue03Brick,
    Cyan01Brick,
    Green01Brick,
    Green02Brick,
    Grey01Brick,
    Orange01Brick,
    Orange02Brick,
    Pink01Brick,
    Pink02Brick,
    Pink03Brick,
    Red01Brick,
    Yellow01Brick
}

public class BrickSpriteList : MonoBehaviour 
{
    //список спрайтов из Инспектора
    public List<Sprite> sprites;

    //словарь спрайтов и тегов
    public Dictionary<BrickTag, Sprite> spriteAndTagDictionary;

    private void Start()
    {
        //инициализация словаря
        spriteAndTagDictionary = new Dictionary<BrickTag, Sprite>();
        //заполнение словаря тегами и спрайтами
        spriteAndTagDictionary.Add(BrickTag.Black01Brick, sprites[0]);
        spriteAndTagDictionary.Add(BrickTag.Blue01Brick, sprites[1]);
        spriteAndTagDictionary.Add(BrickTag.Blue02Brick, sprites[2]);
        spriteAndTagDictionary.Add(BrickTag.Blue03Brick, sprites[3]);
        spriteAndTagDictionary.Add(BrickTag.Cyan01Brick, sprites[4]);
        spriteAndTagDictionary.Add(BrickTag.Green01Brick, sprites[5]);
        spriteAndTagDictionary.Add(BrickTag.Green02Brick, sprites[6]);
        spriteAndTagDictionary.Add(BrickTag.Grey01Brick, sprites[7]);
        spriteAndTagDictionary.Add(BrickTag.Orange01Brick, sprites[8]);
        spriteAndTagDictionary.Add(BrickTag.Orange02Brick, sprites[9]);
        spriteAndTagDictionary.Add(BrickTag.Pink01Brick, sprites[10]);
        spriteAndTagDictionary.Add(BrickTag.Pink02Brick, sprites[11]);
        spriteAndTagDictionary.Add(BrickTag.Pink03Brick, sprites[12]);
        spriteAndTagDictionary.Add(BrickTag.Red01Brick, sprites[13]);
        spriteAndTagDictionary.Add(BrickTag.Yellow01Brick, sprites[14]);
    }

    public Sprite GetSprite(BrickTag tag)
    {
        if (spriteAndTagDictionary.ContainsKey(tag))
        {
            return spriteAndTagDictionary[tag];
        }
        return spriteAndTagDictionary[BrickTag.Red01Brick];
    }

    public string GetTag(BrickTag tag)
    {
        return tag.ToString();
    }
}