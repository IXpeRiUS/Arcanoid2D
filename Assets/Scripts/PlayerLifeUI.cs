using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerLifeUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _lifeLabel;

    private void Start()
    {
        PlayerLifeManager.Instance.OnPlayerLife += UpdateLifeCount;
        UpdateLifeCount(PlayerLifeManager.Instance.GetLife());
    }

    private void UpdateLifeCount(int life)
    {
        _lifeLabel.text = life.ToString();
    }
}
