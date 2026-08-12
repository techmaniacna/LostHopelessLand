using UnityEngine;

public class DanceFloorManager : MonoBehaviour
{
    [Header("Pre-Match Dance Zone Settings")]
    public string zoneName = "Global Fusion VIP Lounge";
    public bool isDanceZoneActive = true;
    public string featuredEmote = "Amapiano Street Flex";

    public void TriggerDanceOff(string dancerName)
    {
        if (isDanceZoneActive)
        {
            Debug.Log("[EMOTE ZONE] " + dancerName + " stepped onto the dance floor and triggered: " + featuredEmote);
        }
    }
}
