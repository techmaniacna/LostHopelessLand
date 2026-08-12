using UnityEngine;

public class MatchResultUI : MonoBehaviour
{
    [Header("Endgame Results")]
    public string matchOutcome = "Victory";
    public int finalScore = 1500;
    public int xpAwarded = 250;

    public void DisplayMatchResults(string outcome, int score)
    {
        matchOutcome = outcome;
        finalScore = score;
        Debug.Log("Match Over! Outcome: " + matchOutcome + " | Score: " + finalScore + " | XP Gained: " + xpAwarded);
    }
}
