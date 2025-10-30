using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void OnLevelComplete()
    {
        string levelName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetInt("Level_" + levelName + "_Completed", 1);
        PlayerPrefs.Save();
        Debug.Log("Уровень " + levelName + " пройден и прогресс сохранён");
    }
}