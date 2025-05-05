using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        // Make sure the cursor is visible and not locked when main menu loads
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        // Set game state to InGame
        if (GameState.Instance != null)
        {
            GameState.Instance.currentPhase = GamePhase.InGame;
        }

        // Load StudyRoom scene (replace with actual scene name if different)
        SceneManager.LoadScene("study room");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit(); // Will quit the build (has no effect in editor)
    }
}