using UnityEngine;


public class KnightController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D knightRb;
    Vector3 inputDir;
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float jumpPower = 15f;

    bool isGround;
    bool isAttack;
    bool isCombo;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        InputKeyboard();
        Jump();
        Attack();
    }

    void FixedUpdate()
    {
        Move();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
        }
    }


    void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);


    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);

        }
    }

    void Move()
    {
        if (inputDir.x != 0)
        {
            animator.SetBool("isRun", true);
            knightRb.linearVelocityX = inputDir.x * moveSpeed;


            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
            
        }
        else if (inputDir.x == 0)
        {
            animator.SetBool("isRun", false);
        }

    }
    


    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!isAttack)
            {
                isAttack = true;
                animator.SetTrigger("Attack");
            }
            else
            {
                isCombo = true;

            }
        }

    }

    public void CheckCombo()
    {
        if (isCombo)
        {
            animator.SetBool("isCombo", true);


        }
        else
        {
            animator.SetBool("isCombo", false);
            // isAttack = false;
        }
    }

    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
    }
}
