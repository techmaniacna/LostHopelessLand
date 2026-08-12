using UnityEngine;

public class DailyRewardManager : MonoBehaviour
{
    [Header("Reward Properties")]
    public int currentLoginStreak = 1;
    public bool rewardClaimedToday = false;

    public void ClaimDailyReward()
    {
        if (!rewardClaimedToday)
        {
            rewardClaimedToday = true;
            Debug.Log("Daily reward claimed for streak day: " + currentLoginStreak);
        }
        else
        {
            Debug.Log("Reward already claimed for today. Come back tomorrow!");
        }
    }
}
