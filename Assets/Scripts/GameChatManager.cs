using UnityEngine;

public class GameChatManager : MonoBehaviour
{
    [Header("Chat Settings")]
    public string channelName = "Squad";

    public void SendChatMessage(string message, string channel)
    {
        channelName = channel;
        Debug.Log("[" + channelName + " Chat] " + message);
    }
}
