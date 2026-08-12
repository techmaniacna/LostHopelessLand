using UnityEngine;

public class MatchProfileStatsManager : MonoBehaviour
{
    [Header("Profile Stats & Career Performance")]
    public string careerKDPRatio = "4.85 K/DP Summary Tracker";
    public bool isProfileStatsActive = true;

    void Start()
    {
        InitializeProfileStats();
    }

    public void InitializeProfileStats()
    {
        if (isProfileStatsActive)
        {
            Debug.Log("[PROFILE STATS] Career stats tracker online. Performance baseline: " + careerKDPRatio);
        }
    }
}
