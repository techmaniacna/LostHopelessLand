using UnityEngine;

public class MatchClanWarManager : MonoBehaviour
{
    [Header("Clan War & Faction Territory Setup")]
    public string territoryStatus = "Faction Dominance War Active";
    public bool isClanWarActive = true;

    void Start()
    {
        InitializeClanWar();
    }

    public void InitializeClanWar()
    {
        if (isClanWarActive)
        {
            Debug.Log("[CLAN WAR] Faction territory system online. Status: " + territoryStatus);
        }
    }
}
