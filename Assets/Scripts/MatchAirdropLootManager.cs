using UnityEngine;

public class MatchAirdropLootManager : MonoBehaviour
{
    [Header("Airdrop & Care Package Loot Setup")]
    public string airdropLootQuality = "Legendary Tier Weapons & Medical Supplies";
    public bool isAirdropSystemActive = true;

    void Start()
    {
        InitializeAirdropSystem();
    }

    public void InitializeAirdropSystem()
    {
        if (isAirdropSystemActive)
        {
            Debug.Log("[AIRDROP] Care package loot system online. Contents: " + airdropLootQuality);
        }
    }
}
