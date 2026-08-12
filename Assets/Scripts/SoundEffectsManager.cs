using UnityEngine;

public class SoundEffectsManager : MonoBehaviour
{
    [Header("Audio SFX")]
    public float sfxVolume = 1f;

    public void PlaySoundEffect(string soundName)
    {
        Debug.Log("Playing SFX: " + soundName + " at volume: " + sfxVolume);
    }
}
