using UnityEngine;

public class BountyHunterManager : MonoBehaviour
{
    [Header("Bounty Hunter Rules (In-Game Only)")]
    public int maxBountiesPerMatch = 5; // Exactly 5 bounties per match
    public int activeBountiesCount = 0;
    public int bountyRewardBonusPoints = 10; // Capped strictly at 10 bonus points per bounty

    [Header("Economy Distinction Notice")]
    public string currencyNotice = "Yellow Crystals = Lobby Only (Real Money). Match Coins & Bounties = In-Game Action Only.";

    public void AcceptBountyContract(string targetPlayerName)
    {
        if (activeBountiesCount < maxBountiesPerMatch)
        {
            activeBountiesCount++;
            Debug.Log("[BOUNTY HUNT] Contract accepted on target: " + targetPlayerName + "! Target marked on tactical radar. Active Bounties: " + activeBountiesCount + "/" + maxBountiesPerMatch);
        }
        else
        {
            Debug.LogWarning("[BOUNTY] Match limit of " + maxBountiesPerMatch + " active bounties reached.");
        }
    }

    public void CompleteBounty()
    {
        Debug.Log("[BOUNTY SUCCESS] Target eliminated! Awarded restricted bonus points: +" + bountyRewardBonusPoints);
        activeBountiesCount = Mathf.Max(0, activeBountiesCount - 1);
    }
}
