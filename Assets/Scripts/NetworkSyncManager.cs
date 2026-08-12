using UnityEngine;

public class NetworkSyncManager : MonoBehaviour
{
    [Header("Network Settings")]
    public string serverRegion = "EU_VPN";
    public bool isConnected = true;
    public float ping = 45f;

    void Start()
    {
        Debug.Log("Network Sync Initialized on region: " + serverRegion);
    }
}
