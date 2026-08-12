using UnityEngine;

public class VehicleEntry : MonoBehaviour
{
    [Header("Vehicle Interaction")]
    public string vehicleName = "Armored UAZ";
    public bool isOccupied = false;

    public void EnterVehicle()
    {
        isOccupied = true;
        Debug.Log("Player entered vehicle: " + vehicleName);
    }

    public void ExitVehicle()
    {
        isOccupied = false;
        Debug.Log("Player exited vehicle: " + vehicleName);
    }
}
