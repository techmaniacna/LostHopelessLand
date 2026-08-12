using UnityEngine;

public class MatchLoadingDirector : MonoBehaviour
{
    [Header("Match Loading & Transition Screen Setup")]
    public string loadingStatus = "Seamless Transition & Scene Loading Active";
    public bool isLoadingDirectorActive = true;

    void Start()
    {
        InitializeLoadingDirector();
    }

    public void InitializeLoadingDirector()
    {
        if (isLoadingDirectorActive)
        {
            Debug.Log("[LOADING DIRECTOR] Transition system online. Status: " + loadingStatus);
        }
    }
}
