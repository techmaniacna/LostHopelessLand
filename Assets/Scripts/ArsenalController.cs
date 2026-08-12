using UnityEngine;
using System.Collections.Generic;

public class ArsenalController : MonoBehaviour
{
    [Header("Arsenal Settings")]
    public bool isLocked = true;
    public bool requiresKey = true;
    
    [Header("High-Tier Loot Pool")]
    public List<string> legendaryLoot = new List<string> { "Level 3 Helmet", "Level 3 Vest", "Silenced AR", "Advanced Medkit" };

    public void UnlockArsenal(bool hasKey)
    {
        if (requiresKey && !hasKey)
        {
            Debug.Log("Arsenal locked! Find an Arsenal Key first.");
            return;
        }

        isLocked = false;
        Debug.Log("Arsenal Unlocked! Legendary loot available.");
    }
}
