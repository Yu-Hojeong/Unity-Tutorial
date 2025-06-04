using UnityEngine;

public class CatController : MonoBehaviour
{
    Rigidbody2D catRb;
    public SoundManager soundManager;
    public float jumpPower = 10f;
    bool isGround = false;
    int jumpCount = 0;
    Animator animator;
    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
                jumpCount++;
                animator.SetTrigger("Jump");
                soundManager.OnJumpSound();
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            jumpCount = 0;
            animator.SetTrigger("Ground");
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }  
    }
}
