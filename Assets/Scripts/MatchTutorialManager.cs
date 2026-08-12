using UnityEngine;

public class MatchTutorialManager : MonoBehaviour
{
    [Header("New Player Tutorial & Onboarding")]
    public string tutorialStage = "Interactive Combat & Looting Drill Active";
    public bool isTutorialActive = true;

    void Start()
    {
        InitializeTutorial();
    }

    public void InitializeTutorial()
    {
        if (isTutorialActive)
        {
            Debug.Log("[TUTORIAL] Onboarding module online. Current phase: " + tutorialStage);
        }
    }
}
