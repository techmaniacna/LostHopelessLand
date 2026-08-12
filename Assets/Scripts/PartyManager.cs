using UnityEngine;
using System.Collections.Generic;

public class PartyManager : MonoBehaviour
{
    [Header("Party Settings")]
    public string partyLeader = "TechManiac";
    public List<string> partyMembers = new List<string>();
    public int maxPartySize = 4;

    public void InvitePlayer(string playerName)
    {
        if (partyMembers.Count < maxPartySize - 1)
        {
            partyMembers.Add(playerName);
            Debug.Log("Player invited to squad: " + playerName);
        }
        else
        {
            Debug.Log("Party is full!");
        }
    }
}
