using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [Header("Initialization Settings")]
    public string gameVersion = "1.0.0";
    public bool isInitialized = false;

    void Awake()
    {
        InitializeGameSystems();
    }

    void InitializeGameSystems()
    {
        if (!isInitialized)
        {
            isInitialized = true;
            Debug.Log("Lost Hopeless Land - Version " + gameVersion + " initialized successfully.");
        }
    }
}
