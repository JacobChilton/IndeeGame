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
    public int gameState = 0;
    private float originalGravityScale;

    // Start is called before the first frame update
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
        originalGravityScale = RB2D.gravityScale;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameState = 0;
      
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameState = 1;
            RB2D.gravityScale = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameState = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            gameState = 3;
        }

        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, 0.5f, whatIsGround);

        RB2D.velocity = new Vector2(Input.GetAxis("Horizontal") * xSpeed, RB2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }
            
        }

        if (gameState == 0){
            if (Input.GetKeyDown(KeyCode.W))
            {
                StartCoroutine(InvertGravityForSeconds(-1, 2f));
            }
        }
        else if (gameState == 1)
        {

        }
        else if (gameState == 2)
        {

        }
        else if (gameState == 3)
        {

        }

    }

    IEnumerator InvertGravityForSeconds(float invertedGravity, float duration)
    {
        RB2D.gravityScale = invertedGravity;
     

        yield return new WaitForSeconds(duration);
        


        RB2D.gravityScale = originalGravityScale;
    }

    //IEnumerator WaitForFunction(int num)
    //{
    //    yield return new WaitForSeconds(num);
    //    confirm = true;
    //}

    private void Jump()
    {
        RB2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}
