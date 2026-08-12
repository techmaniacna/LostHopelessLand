using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [Header("Player Stats")]
    public int health = 100;
    public int armorLevel = 0;
    public bool hasArsenalKey = false;

    [Header("Component References")]
    public MobileTouchController touchController;

    void Start()
    {
        Debug.Log("Player Initialized with 100 HP. Ready for drop.");
    }
}
