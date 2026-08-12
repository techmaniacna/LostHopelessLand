using UnityEngine;

public class MatchMissionTrackerManager : MonoBehaviour
{
    [Header("Mission & Objective Tracker Setup")]
    public string missionStatus = "In-Match Tactical Objectives & Side Quests Active";
    public bool isMissionTrackerActive = true;

    void Start()
    {
        InitializeMissionTracker();
    }

    public void InitializeMissionTracker()
    {
        if (isMissionTrackerActive)
        {
            Debug.Log("[MISSION TRACKER] Objective tracking system online. Status: " + missionStatus);
        }
    }
}
