using UnityEngine;

public class MatchAnalyticsManager : MonoBehaviour
{
    [Header("Match Telemetry")]
    public float survivalTime = 0f;
    public int shotsFired = 0;
    public int enemiesEliminated = 0;

    void Update()
    {
        survivalTime += Time.deltaTime;
    }

    public void RecordKill()
    {
        enemiesEliminated++;
        Debug.Log("Analytics: Elimination recorded. Total kills: " + enemiesEliminated);
    }
}
