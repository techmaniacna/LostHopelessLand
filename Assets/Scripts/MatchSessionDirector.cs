using UnityEngine;

public class MatchSessionDirector : MonoBehaviour
{
    [Header("Match Flow & State Control")]
    public bool isMatchActive = false;
    public float matchDurationTimer = 0.0f;
    public int totalActivePlayers = 50;

    void Start()
    {
        InitializeMatchSession();
    }

    public void InitializeMatchSession()
    {
        isMatchActive = true;
        matchDurationTimer = 0.0f;
        Debug.Log("[MATCH DIRECTOR] Match session officially started. Player count: " + totalActivePlayers + ". Let the battle royale begin!");
    }

    void Update()
    {
        if (isMatchActive)
        {
            matchDurationTimer += Time.deltaTime;
        }
    }
}
