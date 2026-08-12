using UnityEngine;

public class LoadingScreenManager : MonoBehaviour
{
    [Header("Loading Settings")]
    public string targetSceneName = "BattleRoyaleMap";
    public float loadProgress = 0f;
    public bool isLoading = false;

    public void StartLoadingScene(string sceneName)
    {
        targetSceneName = sceneName;
        isLoading = true;
        loadProgress = 0f;
        Debug.Log("Loading initiated for scene: " + targetSceneName);
    }

    public void UpdateProgress(float progressValue)
    {
        if (isLoading)
        {
            loadProgress = progressValue;
            Debug.Log("Loading Progress: " + (loadProgress * 100f) + "%");
        }
    }
}
