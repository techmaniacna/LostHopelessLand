using UnityEngine;

public class SoundEffectsManager : MonoBehaviour
{
    [Header("Audio Settings")]
    public float sfxVolume = 1.0f;

    public void PlaySoundEffect(string clipName)
    {
        Debug.Log("Playing SFX: " + clipName + " at volume " + sfxVolume);
    }
}
