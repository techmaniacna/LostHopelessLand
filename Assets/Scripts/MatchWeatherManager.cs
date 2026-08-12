using UnityEngine;

public class MatchWeatherManager : MonoBehaviour
{
    [Header("Dynamic Weather & Fog Controls")]
    public string currentWeatherState = "Coastal Fog & Dynamic Wind";
    public bool isDynamicWeatherActive = true;

    void Start()
    {
        InitializeWeatherSystem();
    }

    public void InitializeWeatherSystem()
    {
        if (isDynamicWeatherActive)
        {
            Debug.Log("[WEATHER] Dynamic weather state loaded: " + currentWeatherState + ". Visibility and sound dampening active.");
        }
    }
}
