using UnityEngine;

public class MatchEmoteSelectorManager : MonoBehaviour
{
    [Header("Emote & Gesture Radial Wheel")]
    public string defaultEmote = "Tactical Salute / GG";
    public bool isEmoteSystemActive = true;

    void Start()
    {
        InitializeEmoteSystem();
    }

    public void InitializeEmoteSystem()
    {
        if (isEmoteSystemActive)
        {
            Debug.Log("[EMOTE SYSTEM] Gesture wheel online. Default emote loaded: " + defaultEmote);
        }
    }
}
