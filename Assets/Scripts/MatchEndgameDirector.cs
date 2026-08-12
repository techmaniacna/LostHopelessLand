using UnityEngine;

public class MatchEndgameDirector : MonoBehaviour
{
    [Header("Endgame & Winner Declaration")]
    public string victorySequenceName = "BattleRoyale_Winner_Sequence";
    public bool isEndgameTriggered = false;

    void Start()
    {
        // Ready to trigger winner cinematic upon final elimination
    }

    public void TriggerVictory(string winningPlayerOrTeam)
    {
        if (!isEndgameTriggered)
        {
            isEndgameTriggered = true;
            Debug.Log("[ENDGAME] Winner Declared! " + winningPlayerOrTeam + " has secured the Victory Royale. Executing sequence: " + victorySequenceName);
        }
    }
}
