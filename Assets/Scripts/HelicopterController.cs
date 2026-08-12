using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    [Header("Extraction Settings")]
    public string extractionZone = "Extraction Point Alpha";
    public float countdownTimer = 30f;
    public bool isExtractionActive = false;

    public void StartExtractionCountdown()
    {
        isExtractionActive = true;
        Debug.Log("Extraction chopper incoming at " + extractionZone + ". Countdown started: " + countdownTimer + "s");
    }
}
