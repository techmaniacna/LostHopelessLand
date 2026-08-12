using UnityEngine;

public class MatchPartyInviteManager : MonoBehaviour
{
    [Header("Party Invites & Friend System Setup")]
    public string partyInviteStatus = "Squad Party Invites & Friend Management Active";
    public bool isPartyInviteActive = true;

    void Start()
    {
        InitializePartyInvite();
    }

    public void InitializePartyInvite()
    {
        if (isPartyInviteActive)
        {
            Debug.Log("[PARTY INVITE] Party system online. Status: " + partyInviteStatus);
        }
    }
}
