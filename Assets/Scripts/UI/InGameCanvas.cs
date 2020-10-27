using System;
using UnityEngine;

public class InGameCanvas : MonoBehaviour
{
    public static Action OnGameOverEvent;
    public static Action OnGameStartEvent;

    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private GameObject mainMenuPanel;
    [SerializeField]
    private GameObject levelStatusPanel;

    private void Awake()
    {
        OnGameOverEvent += GameOver;
        OnGameStartEvent += StartGame;
    }

    private void OnDestroy()
    {
        OnGameOverEvent -= GameOver;
        OnGameStartEvent -= StartGame;
    }

    private void StartGame()
    {
        mainMenuPanel.SetActive(false);
        levelStatusPanel.SetActive(true);
        GameManager.Instance.StartGame();
    }

    private void GameOver()
    {
        levelStatusPanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
