using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [Header("Daily Quests")]
    public string questTitle = "Survive into Top 10";
    public bool isCompleted = false;

    public void CompleteQuest()
    {
        isCompleted = true;
        Debug.Log("Quest Completed: " + questTitle);
    }
}
