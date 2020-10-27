using System;
using UnityEngine;

public class InGameCanvas : MonoBehaviour
{
    public static Action OnGameOverEvent;

    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private GameObject levelStatusPanel;

    private void Awake()
    {
        OnGameOverEvent += GameOver;
    }

    private void Start()
    {
        StartGame();
    }

    private void OnDestroy()
    {
        OnGameOverEvent -= GameOver;
    }

    private void StartGame()
    {
        levelStatusPanel.SetActive(true);
        GameManager.Instance.StartGame();
    }

    private void GameOver()
    {
        levelStatusPanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
