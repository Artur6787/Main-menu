using UnityEngine;

public class PauseTrigger : MonoBehaviour
{
    [SerializeField] private PauseMenu pauseMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMover>(out PlayerMover player))
        {
            pauseMenu.Pause();
        }
    }
}