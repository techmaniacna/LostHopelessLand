using UnityEngine;

public class AudioController : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioSource sfxSource;
    public AudioSource bgmSource;
    public AudioClip gunshotClip;
    public AudioClip healingClip;

    public void PlayGunshot()
    {
        if (sfxSource != null && gunshotClip != null)
        {
            sfxSource.PlayOneShot(gunshotClip);
            Debug.Log("Playing gunshot sound effect.");
        }
    }
}
