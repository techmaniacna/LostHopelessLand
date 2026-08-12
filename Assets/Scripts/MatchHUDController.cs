using UnityEngine;

public class MatchHUDController : MonoBehaviour
{
    [Header("HUD Elements & Data Binding")]
    public string coinCounterDisplay = "Match Coins: ";
    public string revivalTimerDisplay = "Revival Window: Active (10-Min Limit)";
    public bool isHUDActive = true;

    void Start()
    {
        UpdateHUDDisplay(0, 600.0f);
    }

    public void UpdateHUDDisplay(int currentCoins, float remainingTime)
    {
        if (isHUDActive)
        {
            Debug.Log("[HUD] " + coinCounterDisplay + currentCoins + " | " + revivalTimerDisplay + " [Time Left: " + remainingTime.ToString("F1") + "s]");
        }
    }
}
