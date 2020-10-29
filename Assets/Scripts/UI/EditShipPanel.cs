using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Linq;

public class EditShipPanel : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown cannonDropdown;
    [SerializeField]
    private TMP_Dropdown droneDropdown;

    private void Start()
    {
        PopulateDropdowns();
    }

    private void PopulateDropdowns()
    {
        cannonDropdown.AddOptions(Enum.GetNames(typeof(DroneType)).ToList());
        droneDropdown.AddOptions(Enum.GetNames(typeof(SecondaryCannonType)).ToList());

        SaveAndReturnButton();
    }

    public void SaveAndReturnButton()
    {
        int secondaryCannonIndex = cannonDropdown.value;
        int droneIndex = droneDropdown.value;

        PlayerPrefs.SetInt("selectedSecondaryCannonIndex", secondaryCannonIndex);
        PlayerPrefs.SetInt("selectedDroneIndex", droneIndex);

        MainMenuCanvas.OnMainMenuEnabled?.Invoke();
    }
}
