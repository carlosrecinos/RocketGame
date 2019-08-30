using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    bool gameHasEnded = false;
    bool levelCompleted = false;

    public void EndGame() {
        if (!gameHasEnded || !levelCompleted)
        {
            gameHasEnded = true;
            Invoke("RestartGame", 2);
        }
    }

    public void LevelPassed()
    {
        completeLevelUI.SetActive(true);
        levelCompleted = true;
    }

    void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}