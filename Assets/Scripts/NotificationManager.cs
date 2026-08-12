using UnityEngine;

public class NotificationManager : MonoBehaviour
{
    [Header("Notification Settings")]
    public string activeAlertMessage = "";
    public float displayDuration = 3.0f;
    private float timer = 0f;

    void Update()
    {
        if (activeAlertMessage != "")
        {
            timer += Time.deltaTime;
            if (timer >= displayDuration)
            {
                activeAlertMessage = "";
                timer = 0f;
            }
        }
    }

    public void ShowNotification(string message)
    {
        activeAlertMessage = message;
        timer = 0f;
        Debug.Log("ALERT BANNER: " + message);
    }
}
