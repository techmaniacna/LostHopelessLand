using UnityEngine;

public class MatchPerkTreeManager : MonoBehaviour
{
    [Header("Perk Tree & Passive Buff Setup")]
    public string perkTreeTier = "In-Match Buff Tree & Specialization Active";
    public bool isPerkTreeActive = true;

    void Start()
    {
        InitializePerkTree();
    }

    public void InitializePerkTree()
    {
        if (isPerkTreeActive)
        {
            Debug.Log("[PERK TREE] Passive skill tree system online. Status: " + perkTreeTier);
        }
    }
}
