using UnityEngine;

public class BlueZoneController : MonoBehaviour
{
    [Header("Blue Zone Parameters")]
    public float currentRadius = 1000f;
    public float shrinkSpeed = 2f;
    public int zoneDamage = 1; // Starts at 1 HP, increases later

    void Update()
    {
        ShrinkZone();
    }

    void ShrinkZone()
    {
        if (currentRadius > 50f)
        {
            currentRadius -= shrinkSpeed * Time.deltaTime;
        }
    }
}
