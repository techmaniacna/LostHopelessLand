using UnityEngine;

public class MatchAudioEqualizerManager : MonoBehaviour
{
    [Header("Audio Equalizer & Spatial Sound Profiles")]
    public float masterVolumeLevel = 1.0f;
    public bool isAudioEQActive = true;

    void Start()
    {
        InitializeAudioEQ();
    }

    public void InitializeAudioEQ()
    {
        if (isAudioEQActive)
        {
            Debug.Log("[AUDIO EQ] Spatial audio equalizer online. Master volume locked at: " + (masterVolumeLevel * 100) + "%");
        }
    }
}
