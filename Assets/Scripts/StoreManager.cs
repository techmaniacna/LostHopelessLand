using UnityEngine;

public class StoreManager : MonoBehaviour
{
    [Header("Player Currency & Store")]
    public int playerDiamonds = 1200;
    public int playerCoins = 5000;

    public void PurchaseItem(string itemName, int itemCost)
    {
        if (playerDiamonds >= itemCost)
        {
            playerDiamonds -= itemCost;
            Debug.Log("Successfully purchased: " + itemName + " | Remaining Diamonds: " + playerDiamonds);
        }
        else
        {
            Debug.Log("Not enough diamonds to purchase " + itemName);
        }
    }
}
