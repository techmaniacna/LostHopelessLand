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
            // Radar tracking update logic for mobile HUD
            Vector3 playerPos = playerTransform.position;
        }
    }
}
