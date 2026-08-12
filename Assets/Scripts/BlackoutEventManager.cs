using UnityEngine;

public class BlackoutEventManager : MonoBehaviour
{
    [Header("Dynamic Blackout (Load Shedding) Settings")]
    public string eventName = "Sector Grid Blackout";
    public bool isBlackoutActive = false;
    public float blackoutDuration = 45.0f;

    public void TriggerGridBlackout(string affectedSector)
    {
        isBlackoutActive = true;
        Debug.Log("[EVENT] Power grid failure in " + affectedSector + "! Night-vision and flashlights required.");
    }

    public void RestorePower()
    {
        isBlackoutActive = false;
        Debug.Log("[EVENT] Grid power restored. Floodlights back online.");
    }
}
