using UnityEngine;

public static class DataManager
{
    public static void SaveTotalCoins(int addValue)
    {
        int currentPoints = 0;
        if (PlayerPrefs.HasKey("totalCoins") == true)
        {
            currentPoints = PlayerPrefs.GetInt("totalCoins");
        }
        currentPoints += addValue;
        PlayerPrefs.SetInt("totalCoins", currentPoints);
    }
    public static int LoadTotalCoins()
    {
        if (PlayerPrefs.HasKey("totalCoins") == true)
        {
            return PlayerPrefs.GetInt("totalCoins");
        }
        else
        {
            return 0;
        }
    }
}
