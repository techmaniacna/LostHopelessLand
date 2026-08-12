using UnityEngine;

public class RadioBroadcastManager : MonoBehaviour
{
    [Header("Radio & Emergency Broadcast Settings")]
    public string currentStation = "Kasi-Vibe FM (Soweto Beats)";
    public bool isEmergencyAlertActive = false;

    public void TuneToStation(string stationName)
    {
        currentStation = stationName;
        Debug.Log("[RADIO] Tuned into station: " + currentStation);
    }

    public void BroadcastEmergencyWarning(string warningMessage)
    {
        isEmergencyAlertActive = true;
        Debug.LogWarning("[EMERGENCY BROADCAST] " + warningMessage);
    }
}
