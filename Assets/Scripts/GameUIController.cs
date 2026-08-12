using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    [Header("HUD Elements")]
    public Text healthText;
    public Text ammoText;
    public Text playersAliveText;

    void Update()
    {
        // Placeholder update loop for UI text elements
        if (healthText != null) healthText.text = "HP: 100";
        if (ammoText != null) ammoText.text = "AMMO: 30/30";
        if (playersAliveText != null) playersAliveText.text = "ALIVE: 121";
    }
}
