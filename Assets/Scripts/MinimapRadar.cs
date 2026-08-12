using UnityEngine;

public class MinimapRadar : MonoBehaviour
{
    [Header("Radar Settings")]
    public Transform playerTransform;
    public float radarRange = 100f;

    void Update()
    {
        if (playerTransform != null)
        {
            UpdateRadarBlips();
        }
    }

    void UpdateRadarBlips()
    {
        // Scanning surrounding coordinates for active entities within radar range
    }
}
