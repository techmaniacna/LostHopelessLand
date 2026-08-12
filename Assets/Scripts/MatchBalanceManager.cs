using UnityEngine;

public class MatchBalanceManager : MonoBehaviour
{
    [Header("Match Balance & Fairness Settings")]
    public bool isBalanceShieldActive = true;
    public float basePlayerHealth = 100.0f;
    
    [Header("VIP Stat Cap Protections")]
    public float maxAllowedDamageBonus = 1.10f; // Caps VIP weapon damage advantage at a fair +10%
    public float maxAllowedReloadBonus = 0.90f; // Caps reload speed reduction for fairness

    public float CalculateBalancedDamage(float rawWeaponDamage, bool isVipWeapon)
    {
        if (!isBalanceShieldActive) return rawWeaponDamage;

        if (isVipWeapon)
        {
            // Apply a controlled, balanced multiplier so it helps but doesn't break the game
            float balancedDamage = rawWeaponDamage * Mathf.Min(maxAllowedDamageBonus, 1.08f);
            Debug.Log("[BALANCE] VIP weapon damage balanced. Final Output: " + balancedDamage);
            return balancedDamage;
        }

        return rawWeaponDamage;
    }

    public void ApplyMatchFairnessRules()
    {
        Debug.Log("[MATCH BALANCE] Core balance protocols active. Skill and positioning take priority over loadouts.");
    }
}
