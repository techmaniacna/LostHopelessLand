using UnityEngine;

public class MatchVisualEffectsManager : MonoBehaviour
{
    [Header("Particle & Special Effects Quality")]
    public string vfxQualitySetting = "Ultra / High Density Particle LODs";
    public bool isVFXManagerActive = true;

    void Start()
    {
        InitializeVFXManager();
    }

    public void InitializeVFXManager()
    {
        if (isVFXManagerActive)
        {
            Debug.Log("[VFX MANAGER] Visual effects manager online. Quality profile: " + vfxQualitySetting);
        }
    }
}
