using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    [SerializeField] private Button[] levelButtons;
    [SerializeField] private string[] levelSceneNames;

    private void Start()
    {
        UpdateLevelAccess();
    }

    private void UpdateLevelAccess()
    {
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i == 0)
            {
                levelButtons[i].interactable = true;
            }
            else
            {
                string previousLevelName = levelSceneNames[i - 1];
                bool previousLevelCompleted = PlayerPrefs.GetInt("Level_" + previousLevelName + "_Completed", 0) == 1;

                levelButtons[i].interactable = previousLevelCompleted;
            }
        }
    }

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex >= 0 && levelIndex < levelSceneNames.Length)
        {
            string sceneToLoad = levelSceneNames[levelIndex];

            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}