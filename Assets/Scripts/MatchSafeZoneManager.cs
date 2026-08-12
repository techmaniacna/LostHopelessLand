using UnityEngine;

public class MatchSafeZoneManager : MonoBehaviour
{
    [Header("Safe Zone & Gas Shrink Timers")]
    public float zoneShrinkSpeed = 5.0f;
    public bool isSafeZoneActive = true;

    void Start()
    {
        InitializeSafeZone();
    }

    public void InitializeSafeZone()
    {
        if (isSafeZoneActive)
        {
            Debug.Log("[SAFE ZONE] Gas shrink mechanics online. Shrink speed locked at: " + zoneShrinkSpeed);
        }
    }
}
