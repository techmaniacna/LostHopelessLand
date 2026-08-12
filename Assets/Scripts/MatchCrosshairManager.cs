using UnityEngine;

public class MatchCrosshairManager : MonoBehaviour
{
    [Header("Crosshair & Hitmarker Customization")]
    public string crosshairStyle = "Dynamic Tactical Dot / Hitmarker Audio Enabled";
    public bool isCrosshairSystemActive = true;

    void Start()
    {
        InitializeCrosshairSystem();
    }

    public void InitializeCrosshairSystem()
    {
        if (isCrosshairSystemActive)
        {
            Debug.Log("[CROSSHAIR] Custom crosshair profile online. Style: " + crosshairStyle);
        }
    }
}
