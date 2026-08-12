using UnityEngine;
using System.Collections.Generic;

public class MailboxManager : MonoBehaviour
{
    [Header("Inbox System")]
    public List<string> unreadMessages = new List<string> { "Welcome Reward: 100 Diamonds", "Patch Notes v1.0 Live" };

    public void ClaimMessageReward(int messageIndex)
    {
        if (messageIndex >= 0 && messageIndex < unreadMessages.Count)
        {
            string claimed = unreadMessages[messageIndex];
            unreadMessages.RemoveAt(messageIndex);
            Debug.Log("Claimed reward from message: " + claimed);
        }
        else
        {
            Debug.Log("Invalid message index or already claimed.");
        }
    }
}
