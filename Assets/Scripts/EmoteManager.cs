using UnityEngine;

public class EmoteManager : MonoBehaviour
{
    [Header("Emote Wheel")]
    public string activeEmote = "Thumbs Up";

    public void PlayEmote(string emoteName)
    {
        activeEmote = emoteName;
        Debug.Log("Playing Emote/Gesture: " + activeEmote);
    }
}
