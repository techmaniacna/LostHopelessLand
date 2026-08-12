using UnityEngine;

public class MatchVoiceChatManager : MonoBehaviour
{
    [Header("Voice Chat & Squad Comms Setup")]
    public string voiceChatStatus = "Proximity & Squad Voice Channels Active";
    public bool isVoiceChatActive = true;

    void Start()
    {
        InitializeVoiceChat();
    }

    public void InitializeVoiceChat()
    {
        if (isVoiceChatActive)
        {
            Debug.Log("[VOICE CHAT] Comms system online. Status: " + voiceChatStatus);
        }
    }
}
