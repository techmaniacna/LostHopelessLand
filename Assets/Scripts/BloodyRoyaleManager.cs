using UnityEngine;
using System.Collections.Generic;

public class BloodyRoyaleManager : MonoBehaviour
{
    [Header("Bloody Royale Settings")]
    public string modeName = "Bloody Royale (8v8 Clash)";
    public int currentRound = 1;
    public int maxRounds = 7; // Best of 7 rounds wins

    [Header("Team Scores")]
    public int teamAlphaScore = 0;
    public int teamBravoScore = 0;

    [Header("Lobby Loadout Selection")]
    public string selectedPrimaryWeapon = "Assault Rifle";
    public string selectedSecondaryWeapon = "Submachine Gun";

    public void SelectLoadout(string primary, string secondary)
    {
        selectedPrimaryWeapon = primary;
        selectedSecondaryWeapon = secondary;
        Debug.Log("Bloody Royale Loadout Confirmed -> Primary: " + selectedPrimaryWeapon + " | Secondary: " + selectedSecondaryWeapon);
    }

    public void WinRound(string winningTeam)
    {
        if (winningTeam == "Alpha") teamAlphaScore++;
        else if (winningTeam == "Bravo") teamBravoScore++;

        Debug.Log("Round " + currentRound + " over! Score -> Alpha: " + teamAlphaScore + " | Bravo: " + teamBravoScore);
        currentRound++;
    }
}
