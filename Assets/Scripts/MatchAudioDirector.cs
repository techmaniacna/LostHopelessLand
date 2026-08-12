using UnityEngine;

public class MatchAudioDirector : MonoBehaviour
{
    [Header("Match Sound Effects & Atmosphere")]
    public string ambientTrack = "BattleRoyale_Storm_Loop";
    public bool isAudioSystemActive = true;

    void Start()
    {
        PlayMatchStartSound();
    }

    public void PlayMatchStartSound()
    {
        if (isAudioSystemActive)
        {
            Debug.Log("[AUDIO] Playing tactical deployment sound effect and starting track: " + ambientTrack);
        }
    }

    public void PlayBountyCompleteCue()
    {
        Debug.Log("[AUDIO] Playing high-priority bounty reward chime (+10 bonus points secured).");
    }
}
