using UnityEngine;

public class MatchQuestMissionManager : MonoBehaviour
{
    [Header("Match Quest & Mission Objectives")]
    public string activeMissionName = "Eliminate 3 Opponents & Survive Top 10";
    public bool isQuestSystemActive = true;

    void Start()
    {
        InitializeQuestSystem();
    }

    public void InitializeQuestSystem()
    {
        if (isQuestSystemActive)
        {
            Debug.Log("[QUEST SYSTEM] In-match mission tracker online. Objective: " + activeMissionName);
        }
    }
}
