using UnityEngine;

public class MatchTutorialInjector : MonoBehaviour
{
    [Header("In-Game Tips & Guidance")]
    public bool isTutorialActive = true;
    public string sampleTip = "Tip: Use Match Coins at the store to buy revival beacons or tactical gear!";

    void Start()
    {
        DisplayTip();
    }

    public void DisplayTip()
    {
        if (isTutorialActive)
        {
            Debug.Log("[TUTORIAL] " + sampleTip);
        }
    }
}
