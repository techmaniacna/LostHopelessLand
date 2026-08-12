using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [Header("Player Preferences")]
    public float masterVolume = 1.0f;
    public float cameraSensitivity = 2.5f;
    public string graphicsQuality = "High";

    public void UpdateMasterVolume(float volume)
    {
        masterVolume = Mathf.Clamp01(volume);
        Debug.Log("Master Volume set to: " + (masterVolume * 100f) + "%");
    }

    public void UpdateSensitivity(float sensitivity)
    {
        cameraSensitivity = sensitivity;
        Debug.Log("Camera Sensitivity set to: " + cameraSensitivity);
    }
}
