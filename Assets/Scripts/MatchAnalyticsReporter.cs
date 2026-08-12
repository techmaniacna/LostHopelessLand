using UnityEngine;

public class MatchAnalyticsReporter : MonoBehaviour
{
    [Header("Match Performance Telemetry")]
    public int totalKillsRecorded = 0;
    public int totalBountiesCompleted = 0;
    public int totalRevivalsExecuted = 0;

    public void LogMatchSummary(int finalCoins, float matchDuration)
    {
        Debug.Log("[ANALYTICS] --- MATCH PERFORMANCE REPORT ---");
        Debug.Log("[ANALYTICS] Total Duration: " + matchDuration.ToString("F1") + "s");
        Debug.Log("[ANALYTICS] Total Kills: " + totalKillsRecorded + " | Final Match Coins: " + finalCoins);
        Debug.Log("[ANALYTICS] Bounties Cleared: " + totalBountiesCompleted + " | Teammate Revivals: " + totalRevivalsExecuted);
        Debug.Log("[ANALYTICS] ----------------------------------------");
    }
}
