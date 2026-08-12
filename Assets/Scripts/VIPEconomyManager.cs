using UnityEngine;

public class VIPEconomyManager : MonoBehaviour
{
    [Header("VIP & Currency System")]
    public int normalCurrencyBalance = 50000; // Standard in-game cash
    public int yellowCrystalBalance = 1500;  // Premium currency from real money
    public int totalSpentCrystals = 0;
    public int currentVIPLevel = 0; // Ranges from VIP 1 to VIP 20

    [Header("Legendary Loadout Perks")]
    public string legendaryWeaponUnlock = "Gold-Inlay Viper Assault Rifle (VIP 10 Perk)";
    public float reloadSpeedAdvantage = 0.055f; // Slight percentage edge for spenders

    public void SpendYellowCrystals(int amount)
    {
        if (yellowCrystalBalance >= amount)
        {
            yellowCrystalBalance -= amount;
            totalSpentCrystals += amount;
            EvaluateVIPProgress();
            Debug.Log("[VIP ECONOMY] Spent " + amount + " Yellow Crystals. Total Spent: " + totalSpentCrystals);
        }
        else
        {
            Debug.LogWarning("[VIP ECONOMY] Transaction failed: Not enough Yellow Crystals!");
        }
    }

    public void EvaluateVIPProgress()
    {
        // Calculate VIP level dynamically based on crystals spent up to VIP 20
        int calculatedLevel = totalSpentCrystals / 500; 
        currentVIPLevel = Mathf.Clamp(calculatedLevel, 1, 20);
        
        Debug.Log("[VIP SYSTEM] Current VIP Rank Updated: VIP " + currentVIPLevel);
        
        if (currentVIPLevel >= 10)
        {
            Debug.Log("[LEGENDARY PERK] Unlocked tactical advantage: " + legendaryWeaponUnlock);
        }
    }
}
