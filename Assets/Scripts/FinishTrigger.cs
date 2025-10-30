using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private LevelComplete levelComplete;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMover>(out _))
        {
            levelComplete.OnLevelComplete();
        }
    }
}