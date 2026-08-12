using UnityEngine;
using System.Collections.Generic;

public class ClanManager : MonoBehaviour
{
    [Header("Clan Details")]
    public string clanName = "NamibianElite";
    public string clanTag = "[NAM]";
    public List<string> clanMembers = new List<string> { "TechManiac", "ShadowSniper", "ViperX" };

    public void DonateToClan(int donationAmount)
    {
        Debug.Log(clanTag + " " + clanName + " received a contribution of " + donationAmount + " coins!");
    }
}
