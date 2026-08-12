using UnityEngine;

public class MatchCraftingManager : MonoBehaviour
{
    [Header("Crafting & Gear Upgrade Setup")]
    public string craftingTier = "Workbench Gear Upgrading & Salvage Active";
    public bool isCraftingActive = true;

    void Start()
    {
        InitializeCrafting();
    }

    public void InitializeCrafting()
    {
        if (isCraftingActive)
        {
            Debug.Log("[CRAFTING] Workbench gear system online. Status: " + craftingTier);
        }
    }
}
