using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    [Header("Achievement Status")]
    public bool firstWinUnlocked = false;
    public bool sharpshooterUnlocked = false;

    public void UnlockAchievement(string achievementName)
    {
        if (achievementName == "FirstWin" && !firstWinUnlocked)
        {
            firstWinUnlocked = true;
            Debug.Log("Achievement Unlocked: First Victory Royale!");
        }
        else if (achievementName == "Sharpshooter" && !sharpshooterUnlocked)
        {
            sharpshooterUnlocked = true;
            Debug.Log("Achievement Unlocked: Sharpshooter (10 Elimination Milestone)!");
        }
    }
}
