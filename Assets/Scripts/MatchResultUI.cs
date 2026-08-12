using UnityEngine;

public class MatchResultUI : MonoBehaviour
{
    [Header("Match Stats")]
    public int finalRank = 1;
    public int totalKills = 5;
    public bool isVictory = false;

    void Start()
    {
        DisplayMatchResults();
    }

    void DisplayMatchResults()
    {
        if (finalRank == 1)
        {
            isVictory = true;
            Debug.Log("VICTORY ROYALE! Rank: #" + finalRank + " | Kills: " + totalKills);
        }
        else
        {
            Debug.Log("MATCH OVER. Rank: #" + finalRank + " | Kills: " + totalKills);
        }
    }
}
