using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public string vehiclePrefabName = "Buggy";
    public bool hasSpawned = false;

    public void SpawnVehicle()
    {
        if (!hasSpawned)
        {
            hasSpawned = true;
            Debug.Log("Spawning vehicle: " + vehiclePrefabName + " at coordinates.");
        }
    }
}
