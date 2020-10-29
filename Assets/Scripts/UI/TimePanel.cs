using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimePanel : MonoBehaviour
{
    public static Action<float> OnTimeChange;
    [SerializeField]
    private TextMeshProUGUI timer;

    private void Awake()
    {
        OnTimeChange += SetTime;
    }

    private void OnDestroy()
    {
        OnTimeChange -= SetTime;
    }

    private void SetTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
