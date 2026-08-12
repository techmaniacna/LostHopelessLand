using UnityEngine;

public class MatchAnalyticsManager : MonoBehaviour
{
    [Header("Match Telemetry")]
    public float survivalTimeSeconds = 0f;
    public float totalDamageDealt = 0f;
    public float shootingAccuracy = 0.0f;

    void Update()
    {
        survivalTimeSeconds += Time.deltaTime;
    }

    public void RecordDamage(float damage)
    {
        totalDamageDealt += damage;
        Debug.Log("Damage recorded: " + damage + " | Total: " + totalDamageDealt);
    }
}
