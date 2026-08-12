using UnityEngine;

public class DailyRewardManager : MonoBehaviour
{
    [Header("Login Streak")]
    public int currentStreakDay = 1;
    public bool hasClaimedToday = false;

    public void ClaimDailyReward()
    {
        if (!hasClaimedToday)
        {
            hasClaimedToday = true;
            Debug.Log("Claimed reward for Day " + currentStreakDay);
        }
        else
        {
            Debug.Log("Daily reward already claimed today.");
        }
    }
}
