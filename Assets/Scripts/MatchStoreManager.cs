using UnityEngine;

public class MatchStoreManager : MonoBehaviour
{
    [Header("Match Currency & Economy (Balanced)")]
    public int matchCoins = 0; 
    public int coinsPerKill = 150; // Exactly 150 coins per kill

    [Header("Revival System Settings (10-Min Limit)")]
    public float matchElapsedTime = 0.0f;
    public float revivalTimeLimit = 600.0f; // Strict 10-minute window (600 seconds)
    public int revivalCost = 600; // Exactly 4 kills (600 coins) per teammate revival

    [Header("In-Game Store Inventory")]
    public string rareGunItem = "Rare Tactical SMG";
    public int rareGunPrice = 1000;
    public string revivalCallItem = "Emergency Revival Beacon";
    public int revivalCallPrice = 600;

    void Update()
    {
        if (matchElapsedTime < revivalTimeLimit)
        {
            matchElapsedTime += Time.deltaTime;
        }
    }

    public void AddKillCoins(int killCount)
    {
        int earned = killCount * coinsPerKill;
        matchCoins += earned;
        Debug.Log("[STORE] Secured " + killCount + " kill(s). Earned +" + earned + " match coins! Total: " + matchCoins);
    }

    public void ReviveTeammate(string teammateName)
    {
        if (matchElapsedTime > revivalTimeLimit)
        {
            Debug.LogWarning("[REVIVAL LOCKED] The 10-minute revival window has closed. No more respawns!");
            return;
        }

        if (matchCoins >= revivalCost)
        {
            matchCoins -= revivalCost;
            Debug.Log("[REVIVAL SUCCESS] Teammate " + teammateName + " redeployed! Remaining coins: " + matchCoins);
        }
        else
        {
            Debug.LogWarning("[REVIVAL FAILED] Need " + revivalCost + " coins (4 kills) to revive.");
        }
    }
}
