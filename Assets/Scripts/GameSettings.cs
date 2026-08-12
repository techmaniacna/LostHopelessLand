using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [Header("Player Preferences")]
    public float masterVolume = 1f;
    public float mouseSensitivity = 2f;
    public int graphicsQualityLevel = 2; // 0: Low, 1: Medium, 2: High

    public void SetMasterVolume(float volume)
    {
        masterVolume = volume;
        Debug.Log("Master volume updated to: " + masterVolume);
    }

    public void SetSensitivity(float sensitivity)
    {
        mouseSensitivity = sensitivity;
        Debug.Log("Look sensitivity updated to: " + mouseSensitivity);
    }

    public void SetGraphicsQuality(int qualityIndex)
    {
        graphicsQualityLevel = qualityIndex;
        QualitySettings.SetQualityLevel(graphicsQualityLevel);
        Debug.Log("Graphics quality set to index: " + graphicsQualityLevel);
    }
}
