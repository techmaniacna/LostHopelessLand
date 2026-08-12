using UnityEngine;

public class MatchUINotificationManager : MonoBehaviour
{
    [Header("UI Notification & Toast Alert Setup")]
    public string notificationStatus = "In-Match Toast Alerts & Announcements Active";
    public bool isUINotificationActive = true;

    void Start()
    {
        InitializeUINotification();
    }

    public void InitializeUINotification()
    {
        if (isUINotificationActive)
        {
            Debug.Log("[UI NOTIFICATION] Toast alert system online. Status: " + notificationStatus);
        }
    }
}
