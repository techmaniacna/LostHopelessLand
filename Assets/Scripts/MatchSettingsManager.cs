using UnityEngine;

public class MatchSettingsManager : MonoBehaviour
{
    [Header("Match Options & Customization Settings")]
    public string settingsProfile = "High-Performance User Prefs Active";
    public bool isSettingsSystemActive = true;

    void Start()
    {
        InitializeSettings();
    }

    public void InitializeSettings()
    {
        if (isSettingsSystemActive)
        {
            Debug.Log("[SETTINGS] Customization manager online. Current profile: " + settingsProfile);
        }
    }
}
