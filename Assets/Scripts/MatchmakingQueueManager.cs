using UnityEngine;

public class MatchmakingQueueManager : MonoBehaviour
{
    [Header("Matchmaking & Lobby Queue Setup")]
    public string queueStatus = "Ranked & Casual Matchmaking Queue Active";
    public bool isMatchmakingActive = true;

    void Start()
    {
        InitializeMatchmaking();
    }

    public void InitializeMatchmaking()
    {
        if (isMatchmakingActive)
        {
            Debug.Log("[MATCHMAKING] Queue system online. Status: " + queueStatus);
        }
    }
}
