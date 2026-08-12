using UnityEngine;

public class MatchVehicleTelemetryManager : MonoBehaviour
{
    [Header("Vehicle Dynamics & Fuel Management")]
    public float vehicleFuelCapacity = 100.0f;
    public bool isVehicleSystemActive = true;

    void Start()
    {
        InitializeVehicleSystem();
    }

    public void InitializeVehicleSystem()
    {
        if (isVehicleSystemActive)
        {
            Debug.Log("[VEHICLE] Vehicle telemetry online. Default fuel capacity locked at: " + vehicleFuelCapacity + "%");
        }
    }
}
