using UnityEngine;

public class LootItem : MonoBehaviour
{
    [Header("Item Properties")]
    public string itemName = "Assault Rifle";
    public enum ItemType { Weapon, Armor, Key, Medical }
    public ItemType itemType;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Picked up item: " + itemName);
            Destroy(gameObject);
        }
    }
}
