using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    //при уничтожении задать случ число
    //по числу выбрать бонус
    //создавть объект на нужных координатах
    //направить бонус вниз
    //либо поймать бонус/либо уничтожить

    //нужен список бонусов
    //и свич кейс для выбора и создания

    [SerializeField] Transform _ballPosition;
    [SerializeField] GameObject _extraLifeBonusPrefab;
    public int _bonusChance = 20;
    Rigidbody2D _rb;

    public GameObject CreateBonus(string bonusType)
    {
        return bonusType switch
        {
            "ExtraLifeBonus" => Instantiate(_extraLifeBonusPrefab),
            _ => null,
        };
    }

    public void AddBonus()
    {
        if (Random.Range(0, 101) < _bonusChance)
        {
            string bonusType = GetRandomBonusType();
            GameObject bonus = CreateBonus(bonusType);
            bonus.transform.position = _ballPosition.position;
            bonus.transform.Rotate(new Vector3(0, 0, Random.Range(-25, 26))); //разный угол поворота для разнообразия
        }
    }

    private string GetRandomBonusType()
    {
        string[] bonusTypes = {
        "ExtraLifeBonus"
        };

        return bonusTypes[Random.Range(0, bonusTypes.Length)];
    }
}
