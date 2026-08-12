using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [Header("Initialization Settings")]
    public bool initializeOnStart = true;

    void Start()
    {
        if (initializeOnStart)
        {
            InitializeGameSystems();
        }
    }

    void InitializeGameSystems()
    {
        Debug.Log("LostHopelessLand core systems successfully loaded and initialized.");
    }
}
