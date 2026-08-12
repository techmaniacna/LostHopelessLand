using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    [Header("Lobby Settings")]
    public int currentPlayersInQueue = 0;
    public int maxPlayersPerMatch = 121;
    public bool isMatchStarting = false;

    void Update()
    {
        if (currentPlayersInQueue >= maxPlayersPerMatch && !isMatchStarting)
        {
            StartMatchQueue();
        }
    }

    void StartMatchQueue()
    {
        isMatchStarting = true;
        Debug.Log("Lobby queue full (" + currentPlayersInQueue + "/" + maxPlayersPerMatch + "). Transitioning to match scene.");
    }
}
