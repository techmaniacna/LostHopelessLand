using UnityEngine;

public class FootstepManager : MonoBehaviour
{
    [Header("Surface Audio Settings")]
    public string currentSurface = "Concrete";
    public float stepInterval = 0.5f;
    private float stepTimer = 0f;

    public void TriggerFootstep(string surfaceType)
    {
        currentSurface = surfaceType;
        Debug.Log("Playing footstep sound for surface: " + currentSurface);
    }
}
