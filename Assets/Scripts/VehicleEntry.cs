using UnityEngine;

public class VehicleEntry : MonoBehaviour
{
    [Header("Vehicle States")]
    public bool isOccupied = false;
    public string currentDriver = "";

    public void EnterVehicle(string playerName)
    {
        if (!isOccupied)
        {
            isOccupied = true;
            currentDriver = playerName;
            Debug.Log(playerName + " entered the vehicle.");
        }
        else
        {
            Debug.Log("Vehicle is already occupied!");
        }
    }

    public void ExitVehicle()
    {
        if (isOccupied)
        {
            Debug.Log(currentDriver + " exited the vehicle.");
            isOccupied = false;
            currentDriver = "";
        }
    }
}
