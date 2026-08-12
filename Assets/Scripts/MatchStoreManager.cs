using UnityEngine;

public class MatchStoreManager : MonoBehaviour
{
    [Header("Match Currency & Economy")]
    public int matchCoins = 0; // Earned via kills (150 per kill)
    public int coinsPerKill = 150;

    [Header("Revival System Settings")]
    public float matchElapsedTime = 0.0f;
    public float revivalTimeLimit = 600.0f; // 10 minutes in seconds
    public int revivalCost = 600; // Cost to revive a teammate

    [Header("In-Game Store Inventory")]
    public string rareGunItem = "Rare Tactical SMG";
    public int rareGunPrice = 1000;
    public string revivalCallItem = "Emergency Revival Beacon";
    public int revivalCallPrice = 600;

    void Update()
    {
        // Track match time for the 10-minute revival restriction
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
            Debug.LogWarning("[REVIVAL FAILED] The 10-minute revival window has closed. Teammates cannot be revived anymore!");
            return;
        }

        if (matchCoins >= revivalCost)
        {
            matchCoins -= revivalCost;
            Debug.Log("[REVIVAL SUCCESS] Teammate " + teammateName + " has been called back into action! Remaining coins: " + matchCoins);
        }
        else
        {
            Debug.LogWarning("[REVIVAL FAILED] Not enough match coins! Need " + revivalCost + " coins to revive.");
        }
    }

    public void BuyStoreItem(string itemName, int price)
    {
        if (matchCoins >= price)
        {
            matchCoins -= price;
            Debug.Log("[STORE] Purchased " + itemName + " successfully! Remaining coins: " + matchCoins);
        }
        else
        {
            Debug.LogWarning("[STORE] Purchase failed for " + itemName + ". Insufficient match coins.");
        }
    }
}
