using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Loading battle royale match scene...");
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        Debug.Log("Opening settings panel.");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting application.");
        Application.Quit();
    }
}
