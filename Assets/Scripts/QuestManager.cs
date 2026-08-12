using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [Header("Daily Quests")]
    public string questDescription = "Survive Top 10 in a match";
    public int questProgress = 0;
    public int questTarget = 1;
    public bool isQuestCompleted = false;

    public void ProgressQuest(int amount)
    {
        if (!isQuestCompleted)
        {
            questProgress += amount;
            if (questProgress >= questTarget)
            {
                questProgress = questTarget;
                isQuestCompleted = true;
                Debug.Log("Quest Completed: " + questDescription);
            }
            else
            {
                Debug.Log("Quest Progress: " + questProgress + "/" + questTarget);
            }
        }
    }
}
