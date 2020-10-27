using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coins;

    private void Start()
    {
        coins.text = $"Total coins: {CurrencyManager.instance.totalCurrencys.ToString()}";
    }
    public void RestartButton()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void QuitGameButton()
    {
        Application.Quit();
    }
}
