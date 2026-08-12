using UnityEngine;

public class NetworkSyncHelper : MonoBehaviour
{
    [Header("Network Properties")]
    public float sendRate = 20f; // updates per second
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= (1f / sendRate))
        {
            SyncPlayerState();
            timer = 0f;
        }
    }

    void SyncPlayerState()
    {
        // Transmitting spatial telemetry packet to server
    }
}
