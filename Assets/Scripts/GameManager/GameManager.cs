using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Singleton")]
    public static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    [Header("References")]
    public Transform pivotToRestart;
    public GameObject ship;

    [Header("Behaviour")]
    [HideInInspector] public float gameTime = 1;
    [HideInInspector] public bool endGame;
    [HideInInspector] public bool gameStarted;


    void Awake()
    {
        instance = this;
        gameTime = 0f;
    }


    void Update()
    {
        if (Input.GetButton("Cancel") && endGame)
            RestatGame();
    }


    public void StartGame()
    {
        gameTime = 1f;
        gameStarted = true;
        ShipController playerShip = ship.GetComponent<ShipController>();
        float currentPlayerHealth = playerShip.GetCurrentHealth();
        HealthPanel.OnHealthSetup?.Invoke(currentPlayerHealth, currentPlayerHealth);
    }

    public void EndGame()
    {
        endGame = true;
        SpawnManager.Instance.spawnAble = false;
        gameTime = 0;

        InGameCanvas.OnGameOverEvent?.Invoke();
    }


    void RestatGame()
    {
        endGame = false;
        ship.transform.position = new Vector3(pivotToRestart.position.x, ship.transform.position.y, pivotToRestart.position.z);
        ship.GetComponent<ShipController>().allStatus[ship.GetComponent<ShipController>().healthLevel - 1].health = 100;
        ship.GetComponent<ShipController>().EnebleMesh(true);
        SpawnManager.Instance.DestroyerAllEnemy();
        SpawnManager.Instance.spawnAble = true;
        gameTime = 1;
    }
}
