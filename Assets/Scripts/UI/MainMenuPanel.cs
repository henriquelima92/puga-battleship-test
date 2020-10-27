using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : MonoBehaviour
{
    public void StartGame()
    {
        InGameCanvas.OnGameStartEvent?.Invoke();
    }
    public void EditShip()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
