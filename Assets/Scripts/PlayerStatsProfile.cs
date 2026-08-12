using UnityEngine;

public class PlayerStatsProfile : MonoBehaviour
{
    [Header("Career Statistics")]
    public int totalMatchesPlayed = 0;
    public int totalWins = 0;
    public int totalKills = 0;
    public float winRatePercentage = 0.0f;

    public void UpdateCareerStats(bool wonMatch, int matchKills)
    {
        totalMatchesPlayed++;
        if (wonMatch)
        {
            totalWins++;
        }
        totalKills += matchKills;

        if (totalMatchesPlayed > 0)
        {
            winRatePercentage = ((float)totalWins / totalMatchesPlayed) * 100f;
        }

        Debug.Log("Stats Updated - Matches: " + totalMatchesPlayed + " | Wins: " + totalWins + " | Kills: " + totalKills + " | Win Rate: " + winRatePercentage + "%");
    }
}
