using UnityEngine;

public class MatchDailyRewardManager : MonoBehaviour
{
    [Header("Daily Login & Milestone Tracking")]
    public int loginStreakDays = 7;
    public bool isDailyRewardActive = true;

    void Start()
    {
        InitializeDailyRewards();
    }

    public void InitializeDailyRewards()
    {
        if (isDailyRewardActive)
        {
            Debug.Log("[DAILY REWARD] Milestone tracker online. Current streak baseline: Day " + loginStreakDays);
        }
    }
}
