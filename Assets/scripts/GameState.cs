using UnityEngine;

public enum GamePhase
{
    MainMenu,
    InGame,
    Cutscene
}

public class GameState : MonoBehaviour
{
    public static GameState Instance;

    public GamePhase currentPhase = GamePhase.MainMenu;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject); // persists across scenes
        }
    }
}