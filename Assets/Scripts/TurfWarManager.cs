using UnityEngine;

public class TurfWarManager : MonoBehaviour
{
    [Header("Clan & Turf War Settings")]
    public string controlledLandmark = "Oaxaca Sun Plaza";
    public string dominantClan = "Tech Maniac Syndicate";
    public bool isWarActive = true;

    public void CaptureLandmark(string newClanName)
    {
        dominantClan = newClanName;
        Debug.Log("[TURF WAR] Landmark " + controlledLandmark + " has been captured by Clan: " + dominantClan + "!");
    }
}
