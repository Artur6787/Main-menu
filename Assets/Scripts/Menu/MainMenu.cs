using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChooseLevel()
    {
        SceneManager.LoadScene("LevelManager");
    }

    public void ExitGame()
    {
        Debug.Log("Game Finished");
        Application.Quit();
    }
}