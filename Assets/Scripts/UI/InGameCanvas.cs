using System;
using UnityEngine;

public class InGameCanvas : MonoBehaviour
{
    public static Action OnGameOverEvent;

    [SerializeField]
    private GameObject gameOverPanel;

    private void Awake()
    {
        OnGameOverEvent += EnableGameOverPanel;
    }

    private void OnDestroy()
    {
        OnGameOverEvent -= EnableGameOverPanel;
    }

    private void EnableGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
