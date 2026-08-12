using UnityEngine;

public class MatchAchievementManager : MonoBehaviour
{
    [Header("Achievement & Trophy System Setup")]
    public string achievementStatus = "In-Match Milestones & Trophy Unlocks Active";
    public bool isAchievementActive = true;

    void Start()
    {
        InitializeAchievement();
    }

    public void InitializeAchievement()
    {
        if (isAchievementActive)
        {
            Debug.Log("[ACHIEVEMENT] Trophy system online. Status: " + achievementStatus);
        }
    }
}
