using UnityEngine;

public class MatchLoadoutDropManager : MonoBehaviour
{
    [Header("In-Match Loadout Drops")]
    public string dropBoxStatus = "Available for 150 Match Coins";
    public bool isDropSystemActive = true;

    void Start()
    {
        InitializeLoadoutDrop();
    }

    public void InitializeLoadoutDrop()
    {
        if (isDropSystemActive)
        {
            Debug.Log("[LOADOUT DROP] Tactical drop system initialized. " + dropBoxStatus);
        }
    }
}
