using UnityEngine;

public class MatchEventManager : MonoBehaviour
{
    [Header("Dynamic World Events & Modifiers Setup")]
    public string activeWorldEvent = "Dynamic Weather & Supply Surge Event Active";
    public bool isMatchEventActive = true;

    void Start()
    {
        InitializeMatchEvent();
    }

    public void InitializeMatchEvent()
    {
        if (isMatchEventActive)
        {
            Debug.Log("[MATCH EVENT] Dynamic world modifier system online. Status: " + activeWorldEvent);
        }
    }
}
