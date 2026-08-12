using UnityEngine;
using System.Collections.Generic;

public class BloodyRoyaleManager : MonoBehaviour
{
    [Header("Bloody Royale Settings")]
    public string modeName = "Bloody Royale (8v8 Clash)";
    public int currentRound = 1;
    public int maxRounds = 5; // Best of 5 rounds

    [Header("Team Scores")]
    public int teamAlphaScore = 0;
    public int teamBravoScore = 0;

    [Header("Global Fusion Map Locations")]
    public string[] roundLocations = new string[5] {
        "Round 1: Soweto Main Taxi Rank",
        "Round 2: Oaxaca Sun Plaza",
        "Round 3: Jozi Industrial Railway Yard",
        "Round 4: Mexico City Colonnade Alley",
        "Round 5: The Border Shanty Market"
    };

    [Header("Lobby Loadout Selection")]
    public string selectedPrimaryWeapon = "Assault Rifle";
    public string selectedSecondaryWeapon = "Submachine Gun";

    public void SelectLoadout(string primary, string secondary)
    {
        selectedPrimaryWeapon = primary;
        selectedSecondaryWeapon = secondary;
        Debug.Log("Bloody Royale Loadout Confirmed -> Primary: " + selectedPrimaryWeapon + " | Secondary: " + selectedSecondaryWeapon);
    }

    public void ProgressToNextRound(string winningTeam)
    {
        if (winningTeam == "Alpha") teamAlphaScore++;
        else if (winningTeam == "Bravo") teamBravoScore++;

        if (currentRound < maxRounds)
        {
            currentRound++;
            Debug.Log("Moving to Round " + currentRound + "! Next Arena Location: " + roundLocations[currentRound - 1]);
        }
        else
        {
            Debug.Log("Match Point Reached! Final Score -> Alpha: " + teamAlphaScore + " | Bravo: " + teamBravoScore);
        }
    }
}
