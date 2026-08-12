using UnityEngine;

public class MatchReportingManager : MonoBehaviour
{
    [Header("Player Reporting & Support Ticket System")]
    public string reportingProtocol = "Automated In-Game Ticket Logging Active";
    public bool isReportingActive = true;

    void Start()
    {
        InitializeReporting();
    }

    public void InitializeReporting()
    {
        if (isReportingActive)
        {
            Debug.Log("[REPORTING] Support ticket system online. Status protocol: " + reportingProtocol);
        }
    }
}
