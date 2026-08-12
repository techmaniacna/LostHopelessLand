using UnityEngine;

public class FootstepManager : MonoBehaviour
{
    [Header("Footstep Properties")]
    public float stepInterval = 0.5f;
    private float stepTimer = 0f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            stepTimer += Time.deltaTime;
            if (stepTimer >= stepInterval)
            {
                PlayFootstepSound();
                stepTimer = 0f;
            }
        }
    }

    void PlayFootstepSound()
    {
        Debug.Log("Playing tactical footstep audio effect.");
    }
}
