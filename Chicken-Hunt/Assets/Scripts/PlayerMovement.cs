using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 public float moveSpeed;

 public Rigidbody2D rb;
 private Vector3 velocity = Vector3.zero;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        
        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMove)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMove, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
}
