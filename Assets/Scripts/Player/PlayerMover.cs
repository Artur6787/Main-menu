using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 10f;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput != 0)
        {
            float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
    }
}