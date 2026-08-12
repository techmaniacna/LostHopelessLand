using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [Header("Spawner Configuration")]
    public string spawnPointName = "Highway Spawn 01";
    public bool isVehicleSpawned = true;

    public void RespawnVehicle()
    {
        isVehicleSpawned = true;
        Debug.Log("New vehicle spawned at " + spawnPointName);
    }
}
