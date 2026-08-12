using UnityEngine;

public class MatchPingSystemManager : MonoBehaviour
{
    [Header("Tactical Ping & Communication")]
    public string defaultPingType = "Enemy Spot / Location Marker";
    public bool isPingSystemActive = true;

    void Start()
    {
        InitializePingSystem();
    }

    public void InitializePingSystem()
    {
        if (isPingSystemActive)
        {
            Debug.Log("[PING SYSTEM] Tactical communication channels open. Default marker type: " + defaultPingType);
        }
    }
}
