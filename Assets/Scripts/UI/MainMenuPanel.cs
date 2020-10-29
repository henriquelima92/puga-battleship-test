using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI totalCoins;

    private void Start()
    {
        totalCoins.text = $"Total coins: {DataManager.LoadTotalCoins().ToString()}";
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void EditShip()
    {
        MainMenuCanvas.OnEditShipEnabled?.Invoke();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
