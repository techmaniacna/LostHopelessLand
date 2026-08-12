using UnityEngine;

public class BountyHunterManager : MonoBehaviour
{
    [Header("Bounty Hunter Rules")]
    public int maxBountiesPerMatch = 5;
    public int activeBountiesCount = 0;
    public int bountyRewardPoints = 10; // Capped strictly at 10 bonus points per bounty

    public void AcceptBountyContract(string targetPlayerName)
    {
        if (activeBountiesCount < maxBountiesPerMatch)
        {
            activeBountiesCount++;
            Debug.Log("[BOUNTY] Contract accepted against target: " + targetPlayerName + " | Active Bounties: " + activeBountiesCount + "/" + maxBountiesPerMatch);
        }
        else
        {
            Debug.LogWarning("[BOUNTY] Cannot accept more contracts. Match limit of " + maxBountiesPerMatch + " reached.");
        }
    }

    public void CompleteBounty()
    {
        Debug.Log("[BOUNTY] Target eliminated! Awarded restricted bonus points: +" + bountyRewardPoints);
        activeBountiesCount = Mathf.Max(0, activeBountiesCount - 1);
    }
}
