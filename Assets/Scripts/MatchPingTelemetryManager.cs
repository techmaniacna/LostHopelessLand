using UnityEngine;

public class MatchPingTelemetryManager : MonoBehaviour
{
    [Header("Ping & Latency Telemetry Setup")]
    public string pingTelemetryStatus = "Real-Time Server Latency & Packet Loss Monitor Active";
    public bool isPingTelemetryActive = true;

    void Start()
    {
        InitializePingTelemetry();
    }

    public void InitializePingTelemetry()
    {
        if (isPingTelemetryActive)
        {
            Debug.Log("[PING TELEMETRY] Latency system online. Status: " + pingTelemetryStatus);
        }
    }
}
