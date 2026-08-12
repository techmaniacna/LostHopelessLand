using UnityEngine;

public class VehicleEntry : MonoBehaviour
{
    [Header("Vehicle Status")]
    public bool isOccupied = false;
    public string driverName = "";

    public void EnterVehicle(string playerName)
    {
        if (!isOccupied)
        {
            isOccupied = true;
            driverName = playerName;
            Debug.Log(playerName + " entered vehicle: " + gameObject.name);
        }
    }

    public void ExitVehicle()
    {
        if (isOccupied)
        {
            Debug.Log(driverName + " exited vehicle: " + gameObject.name);
            isOccupied = false;
            driverName = "";
        }
    }
}
