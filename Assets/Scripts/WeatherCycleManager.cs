using UnityEngine;

public class WeatherCycleManager : MonoBehaviour
{
    [Header("Time & Atmosphere Settings")]
    public string currentTimeOfDay = "Golden Hour Dusk";
    public bool isNightTime = false;

    [Header("Dynamic Weather Conditions")]
    public string currentWeather = "Clear Skies";
    public string[] weatherTypes = new string[5] { "Wind Storm", "Heavy Rain", "Dense Fog", "Thick Mist", "Ice Storm" };

    public void ShiftTimeCycle(bool makeItNight)
    {
        isNightTime = makeItNight;
        currentTimeOfDay = isNightTime ? "Deep Night (Flashlight Required)" : "Midday Sun";
        Debug.Log("[TIME] Cycle shifted to: " + currentTimeOfDay);
    }

    public void SetWeatherCondition(int weatherIndex)
    {
        if (weatherIndex >= 0 && weatherIndex < weatherTypes.Length)
        {
            currentWeather = weatherTypes[weatherIndex];
            Debug.Log("[WEATHER] Atmospheric shift active: " + currentWeather);
        }
    }
}
