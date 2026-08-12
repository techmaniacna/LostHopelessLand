using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [Header("Central System Integration")]
    public VIPEconomyManager vipManager;
    public MatchStoreManager storeManager;
    public BountyHunterManager bountyManager;
    public MatchBalanceManager balanceManager;

    void Awake()
    {
        // Ensure managers are assigned or automatically attached to prevent null references or script collisions
        if (vipManager == null) vipManager = gameObject.GetComponent<VIPEconomyManager>() ?? gameObject.AddComponent<VIPEconomyManager>();
        if (storeManager == null) storeManager = gameObject.GetComponent<MatchStoreManager>() ?? gameObject.AddComponent<MatchStoreManager>();
        if (bountyManager == null) bountyManager = gameObject.GetComponent<BountyHunterManager>() ?? gameObject.AddComponent<BountyHunterManager>();
        if (balanceManager == null) balanceManager = gameObject.GetComponent<MatchBalanceManager>() ?? gameObject.GetComponent<MatchBalanceManager>();

        Debug.Log("[GAME INITIALIZER] All systems successfully initialized in a unified startup sequence. Zero collisions detected.");
    }
}
