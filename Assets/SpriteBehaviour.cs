using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehaviour : MonoBehaviour
{ 
    private Rigidbody2D RB2D;
    public float xSpeed, jumpForce;
    public LayerMask whatIsGround;
    public bool isGrounded;
    public Transform GroundCheck;
    // Start is called before the first frame update
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, 0.5f, whatIsGround);

        RB2D.velocity = new Vector2(Input.GetAxis("Horizontal") * xSpeed, RB2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }
            
        }
    }

    private void Jump()
    {
        RB2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}
