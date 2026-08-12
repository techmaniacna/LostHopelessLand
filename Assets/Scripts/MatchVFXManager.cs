using UnityEngine;

public class MatchVFXManager : MonoBehaviour
{
    [Header("Particle & Visual Effects Setup")]
    public string vfxProfile = "High-Density Explosion & Muzzle Flash Particles Active";
    public bool isVFXSystemActive = true;

    void Start()
    {
        InitializeVFXSystem();
    }

    public void InitializeVFXSystem()
    {
        if (isVFXSystemActive)
        {
            Debug.Log("[VFX SYSTEM] Particle and visual effects online. Profile: " + vfxProfile);
        }
    }
}
