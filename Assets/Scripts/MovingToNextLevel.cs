using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingToNextLevel : MonoBehaviour
{
    [SerializeField] private string nextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMover>(out PlayerMover player))
        {
            if (string.IsNullOrEmpty(nextSceneName) == false)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}