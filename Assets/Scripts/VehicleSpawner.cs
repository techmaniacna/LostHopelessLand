using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [Header("Vehicle Spawning")]
    public GameObject vehiclePrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnVehicles();
    }

    void SpawnVehicles()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            if (vehiclePrefab != null && spawnPoint != null)
            {
                Instantiate(vehiclePrefab, spawnPoint.position, spawnPoint.rotation);
                Debug.Log("Spawned vehicle at designated point.");
            }
        }
    }
}
