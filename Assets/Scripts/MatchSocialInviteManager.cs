using UnityEngine;

public class MatchSocialInviteManager : MonoBehaviour
{
    [Header("Social & Party Friend Invites")]
    public string partyInviteStatus = "Ready for Quick Invites & Lobby Joining";
    public bool isSocialSystemActive = true;

    void Start()
    {
        InitializeSocialSystem();
    }

    public void InitializeSocialSystem()
    {
        if (isSocialSystemActive)
        {
            Debug.Log("[SOCIAL SYSTEM] Friend invite manager online. Status: " + partyInviteStatus);
        }
    }
}
