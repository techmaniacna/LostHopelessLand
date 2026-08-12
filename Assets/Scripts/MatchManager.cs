using UnityEngine;

public class MatchManager : MonoBehaviour
{
    [Header("Match States")]
    public bool isMatchActive = false;
    public float matchDuration = 1200f;

    void Start()
    {
        StartMatch();
    }

    void StartMatch()
    {
        isMatchActive = true;
        Debug.Log("Match started! Plane is in the air. Prepare to drop.");
    }
}
