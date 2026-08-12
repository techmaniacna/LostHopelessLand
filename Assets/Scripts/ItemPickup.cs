using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [Header("Item Properties")]
    public string itemName = "Medkit";
    public int itemQuantity = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player picked up: " + itemQuantity + "x " + itemName);
            Destroy(gameObject);
        }
    }
}
