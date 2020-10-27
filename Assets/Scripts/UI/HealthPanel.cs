using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPanel : MonoBehaviour
{
    public static Action<float, float> OnHealthSetup;
    public static Action<float> OnHealthChange;

    private float startHealth;

    [SerializeField]
    private Image healthFill;

    private void Awake()
    {
        OnHealthChange += HealthChange;
        OnHealthSetup += HealthSetup;
    }

    private void OnDestroy()
    {
        OnHealthChange -= HealthChange;
        OnHealthSetup -= HealthSetup;
    }

    private float NormalizeHealth(float health)
    {
        return (health - 0f) / (startHealth - 0f);
    }
    private void HealthSetup(float startHealth, float currentHealth)
    {
        this.startHealth = startHealth;
        healthFill.fillAmount = NormalizeHealth(currentHealth);

        OnHealthSetup -= HealthSetup;
    }
    private void HealthChange(float value)
    {
        healthFill.fillAmount = NormalizeHealth(value);
    }
}
