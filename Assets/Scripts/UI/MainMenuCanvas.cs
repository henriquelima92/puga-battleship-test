using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCanvas : MonoBehaviour
{
    public static Action OnMainMenuEnabled;
    public static Action OnEditShipEnabled;

    [SerializeField]
    private GameObject mainMenuPanel;
    [SerializeField]
    private GameObject editShipPanel;

    private void Awake()
    {
        OnMainMenuEnabled += EnableMainMenu;
        OnEditShipEnabled += EnableEditShipMenu;
    }

    private void OnDestroy()
    {
        OnMainMenuEnabled -= EnableMainMenu;
        OnEditShipEnabled -= EnableEditShipMenu;
    }

    private void EnableMainMenu()
    {
        mainMenuPanel.SetActive(true);
        editShipPanel.SetActive(false);
    }
    private void EnableEditShipMenu()
    {
        editShipPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
}
