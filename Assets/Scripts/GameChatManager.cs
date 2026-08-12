using UnityEngine;
using System.Collections.Generic;

public class GameChatManager : MonoBehaviour
{
    [Header("Chat Settings")]
    public List<string> chatMessages = new List<string>();
    public int maxMessages = 50;

    public void SendChatMessage(string sender, string message)
    {
        string formattedMessage = "[" + sender + "]: " + message;
        chatMessages.Add(formattedMessage);

        if (chatMessages.Count > maxMessages)
        {
            chatMessages.RemoveAt(0);
        }

        Debug.Log(formattedMessage);
    }
}
