using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerLifeUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _lifeLabel;

    private void Start()
    {
        UpdateLifeCount(PlayerLifeManager.Instance.GetLifeCount());
    }

    private void OnEnable()
    {
        PlayerLifeManager.Instance.OnPlayerLife += UpdateLifeCount;
    }

    private void OnDisable()
    {
        PlayerLifeManager.Instance.OnPlayerLife -= UpdateLifeCount;
    }

    private void UpdateLifeCount(int life)
    {
        _lifeLabel.text = life.ToString();
    }
}
