using UnityEngine;

public class MatchClanWarSystemManager : MonoBehaviour
{
    [Header("Clan War & Guild System Setup")]
    public string clanWarStatus = "Guild Territories & In-Match Clan Wars Active";
    public bool isClanWarSystemActive = true;

    void Start()
    {
        InitializeClanWarSystem();
    }

    public void InitializeClanWarSystem()
    {
        if (isClanWarSystemActive)
        {
            Debug.Log("[CLAN WAR] Guild system online. Status: " + clanWarStatus);
        }
    }
}
