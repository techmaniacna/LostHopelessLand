using UnityEngine;

public class MatchBalanceIntegration : MonoBehaviour
{
    [Header("Match Balance Integration")]
    public MatchBalanceManager balanceManager;

    void Start()
    {
        if (balanceManager == null)
        {
            balanceManager = gameObject.AddComponent<MatchBalanceManager>();
        }
        balanceManager.ApplyMatchFairnessRules();
        Debug.Log("[INTEGRATION] Match balance rules successfully linked to session.");
    }
}
