using UnityEngine;

public class MatchPerkTreeProgressionManager : MonoBehaviour
{
    [Header("Perk & Skill Tree Progression Setup")]
    public string perkTreeStatus = "In-Match Ability Upgrades & Perk Tree Active";
    public bool isPerkTreeActive = true;

    void Start()
    {
        InitializePerkTree();
    }

    public void InitializePerkTree()
    {
        if (isPerkTreeActive)
        {
            Debug.Log("[PERK TREE] Progression system online. Status: " + perkTreeStatus);
        }
    }
}
