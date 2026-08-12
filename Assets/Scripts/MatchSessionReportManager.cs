using UnityEngine;

public class MatchSessionReportManager : MonoBehaviour
{
    [Header("Match Session Report & Summary Setup")]
    public string sessionReportStatus = "Post-Match Stats & Performance Summary Active";
    public bool isSessionReportActive = true;

    void Start()
    {
        InitializeSessionReport();
    }

    public void InitializeSessionReport()
    {
        if (isSessionReportActive)
        {
            Debug.Log("[SESSION REPORT] Summary system online. Status: " + sessionReportStatus);
        }
    }
}
