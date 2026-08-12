using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    [Header("Flight Parameters")]
    public float flightSpeed = 15f;
    public float rotationSpeed = 45f;
    public bool isPiloted = false;

    void Update()
    {
        if (isPiloted)
        {
            HandleFlight();
        }
    }

    void HandleFlight()
    {
        // Simple vertical lift and forward flight mechanics for mobile/touch input
        float moveForward = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveForward * flightSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * rotationSpeed * Time.deltaTime);
    }
}
