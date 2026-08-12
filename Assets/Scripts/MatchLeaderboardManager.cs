using UnityEngine;

public class MatchLeaderboardManager : MonoBehaviour
{
    [Header("Global Leaderboard & Regional Rankings")]
    public string leaderboardTier = "Global Top Tier 1% Rank Tracker";
    public bool isLeaderboardActive = true;

    void Start()
    {
        InitializeLeaderboard();
    }

    public void InitializeLeaderboard()
    {
        if (isLeaderboardActive)
        {
            Debug.Log("[LEADERBOARD] Global ranking tracker online. Tier tier status: " + leaderboardTier);
        }
    }
}
