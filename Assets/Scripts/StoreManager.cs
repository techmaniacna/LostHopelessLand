using UnityEngine;
using System.Collections.Generic;

public class StoreManager : MonoBehaviour
{
    [Header("Store & Monetization Settings")]
    public string storeCatalogVersion = "Season 1: Global Fusion Drop";
    public int premiumCurrencyBalance = 1200; // e.g., Gold or Diamonds

    [Header("Limited Edition Showcase")]
    public string featuredWeaponSkin = "Gold-Inlay Assault Rifle";
    public string featuredOutfit = "Soweto Street Style & Aztec Gold Gear";
    public string featuredVehicleSkin = "Matte Black Armored UAZ";
    public string featuredChopperSkin = "Desert Camo Extraction Chopper";
    public int itemPrice = 800;

    public void PurchaseLimitedEditionItem(string itemName, int cost)
    {
        if (premiumCurrencyBalance >= cost)
        {
            premiumCurrencyBalance -= cost;
            Debug.Log("[STORE] Purchase Successful! Acquired: " + itemName + " | Remaining Balance: " + premiumCurrencyBalance);
        }
        else
        {
            Debug.LogWarning("[STORE] Transaction Failed: Insufficient premium currency for " + itemName);
        }
    }
}
