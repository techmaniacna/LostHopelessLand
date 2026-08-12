using UnityEngine;

public class TaxiRankManager : MonoBehaviour
{
    [Header("Taxi Transit Hub Settings")]
    public string hubName = "Soweto Main Taxi Rank";
    public string transitRoute = "Route 01: Central Plaza to Industrial Zone";
    public int farePrice = 50; // In-game cash

    public void BoardTransitVehicle()
    {
        Debug.Log("[TRANSIT] Boarded minibus at " + hubName + ". Traveling along " + transitRoute);
    }
}
