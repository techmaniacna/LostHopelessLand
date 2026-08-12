using UnityEngine;

public class MatchTimerUI : MonoBehaviour
{
    [Header("Match Clock")]
    public float matchDuration = 0f;
    public bool isTimerActive = true;

    void Update()
    {
        if (isTimerActive)
        {
            matchDuration += Time.deltaTime;
        }
    }
}
