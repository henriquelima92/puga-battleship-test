using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinsPanel : MonoBehaviour
{
    public static Action<float> OnCoinsIncreased;

    [SerializeField]
    private TextMeshProUGUI currentCoins;

    private void Awake()
    {
        OnCoinsIncreased += IncreaseCoins;
    }

    private void OnDestroy()
    {
        OnCoinsIncreased -= IncreaseCoins;
    }

    private void IncreaseCoins(float value)
    {
        currentCoins.text = $"{value.ToString()}";
    }
}
