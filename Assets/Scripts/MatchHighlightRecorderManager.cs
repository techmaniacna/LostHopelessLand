using UnityEngine;

public class MatchHighlightRecorderManager : MonoBehaviour
{
    [Header("Highlight Reel & Replay Recorder Setup")]
    public string highlightStatus = "Automatic Killcam & Highlight Reel Buffer Active";
    public bool isHighlightRecorderActive = true;

    void Start()
    {
        InitializeHighlightRecorder();
    }

    public void InitializeHighlightRecorder()
    {
        if (isHighlightRecorderActive)
        {
            Debug.Log("[HIGHLIGHT RECORDER] Replay buffer system online. Status: " + highlightStatus);
        }
    }
}
