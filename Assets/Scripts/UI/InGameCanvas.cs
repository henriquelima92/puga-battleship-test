using System;
using UnityEngine;

public class InGameCanvas : MonoBehaviour
{
    public static Action OnGameOverEvent;
    public static Action OnGameWinEvent;

    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private GameObject gameWinPanel;
    [SerializeField]
    private GameObject levelStatusPanel;

    private void Awake()
    {
        OnGameOverEvent += GameOver;
        OnGameWinEvent += GameWin;
    }

    private void Start()
    {
        StartGame();
    }

    private void OnDestroy()
    {
        OnGameOverEvent -= GameOver;
        OnGameWinEvent -= GameWin;
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
    private void GameWin()
    {
        levelStatusPanel.SetActive(false);
        gameWinPanel.SetActive(true);
    }
}
