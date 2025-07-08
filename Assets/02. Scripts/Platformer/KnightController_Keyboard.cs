using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KnightController_Keyboard : MonoBehaviour, IDamageable
{
    private Animator animator;
    private Rigidbody2D knightRb;
    private Collider2D knightColl;
    [SerializeField] private Image hpBar;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 13f;

    public float hp = 100f;
    public float currHp;
    
    private float atkDamage = 3f;
    
    private bool isGround;
    private bool isAttack;
    private bool isCombo;
    private bool isLadder;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
        knightColl = GetComponent<Collider2D>();

        currHp = hp;
        hpBar.fillAmount = currHp / hp;
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

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            if (other.GetComponent<IDamageable>() != null)
            {
                other.GetComponent<IDamageable>().TakeDamage(atkDamage);
                other.GetComponent<Animator>().SetTrigger("Hit");
            }
        }
        
        if (other.CompareTag("Ladder"))
        {
            isLadder = true;
            knightRb.gravityScale = 0f;
            knightRb.linearVelocity = Vector2.zero;
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isLadder = false;
            knightRb.gravityScale = 2f;
            knightRb.linearVelocity = Vector2.zero;
        }
    }

    void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        inputDir = new Vector3(h, v, 0);
        
        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);

        if (inputDir.y < 0)
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 0.3f);
            GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.35f);
        }
        else
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 1.7f);
            GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.85f);
        }
    }

    void Move()
    {
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
            
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
        }

        if (isLadder && inputDir.y != 0)
        {
            knightRb.linearVelocityY = inputDir.y * moveSpeed;
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
    
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            if (!isAttack)
            {
                isAttack = true;
                atkDamage = 3f;
                animator.SetTrigger("Attack");
            }
            else
                isCombo = true;
        }
    }

    public void WaitCombo()
    {
        if (isCombo)
        {
            atkDamage = 5f;
            animator.SetBool("isCombo", true);
        }
        else
        {
            isAttack = false;
            animator.SetBool("isCombo", false);
        }
    }
     
    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
        animator.SetBool("isCombo", false);
    }

    public void TakeDamage(float damage)
    {
        currHp -= damage;
        hpBar.fillAmount = currHp / hp; // 현재체력 / 최대체력
        if (currHp <= 0f)
            Death();
    }

    public void Death()
    {
        animator.SetTrigger("Death");
        knightColl.enabled = false;
        knightRb.gravityScale = 0f;
    }
}


// using UnityEngine;



// public class KnightController : MonoBehaviour
// {
//     Animator animator;
//     Rigidbody2D knightRb;
//     Vector3 inputDir;
//     float hp = 10;
//     [SerializeField] float moveSpeed = 3f;
//     [SerializeField] float jumpPower = 15f;

//     bool isGround;
//     bool isAttack;
//     bool isCombo;
//     bool isLadder;

//     void Start()
//     {
//         animator = GetComponent<Animator>();
//         knightRb = GetComponent<Rigidbody2D>();
//     }
//     void Update()
//     {
//         InputKeyboard();
//         Jump();
//         Attack();
//     }

//     void FixedUpdate()
//     {
//         Move();
//     }

//     void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.CompareTag("Ground"))
//         {
//             animator.SetBool("isGround", true);
//         }
//     }
//     void OnCollisionExit2D(Collision2D collision)
//     {
//         if (collision.gameObject.CompareTag("Ground"))
//         {
//             animator.SetBool("isGround", false);
//         }
//     }

//     void OnTriggerEnter2D(Collider2D collision)
//     {
//         if (collision.gameObject.CompareTag("Ladder"))
//         {
//             animator.SetBool("isLadder", true);
//             isLadder = true;
//             knightRb.gravityScale = 0f;
//             knightRb.linearVelocity = Vector3.zero;
//         }
//     }

//     void OnTriggerExit2D(Collider2D collision)
//     {
//         if (collision.gameObject.CompareTag("Ladder"))
//         {
//             animator.SetBool("isLadder", true);
//             isLadder = false;
//             knightRb.gravityScale = 1f;
//         }
//     }


//     void InputKeyboard()
//     {
//         float h = Input.GetAxisRaw("Horizontal");
//         float v = Input.GetAxisRaw("Vertical");

//         inputDir = new Vector3(h, v, 0);


//     }

//     void Jump()
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             animator.SetTrigger("Jump");
//             knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);

//         }
//     }

//     void Move()
//     {
//         if (inputDir.x != 0)
//         {
//             animator.SetBool("isRun", true);
//             knightRb.linearVelocityX = inputDir.x * moveSpeed;


//             var scaleX = inputDir.x > 0 ? 1 : -1;
//             transform.localScale = new Vector3(scaleX, 1, 1);

//         }
//         else if (inputDir.x == 0)
//         {
//             animator.SetBool("isRun", false);
//         }

//         if (isLadder && inputDir.y != 0)
//         {
//             knightRb.linearVelocityY = inputDir.y * moveSpeed;
//         }

//     }



//     void Attack()
//     {
//         if (Input.GetKeyDown(KeyCode.Z))
//         {
//             if (!isAttack)
//             {
//                 isAttack = true;
//                 animator.SetTrigger("Attack");
//             }
//             else
//             {
//                 isCombo = true;

//             }
//         }

//     }

//     public void CheckCombo()
//     {
//         if (isCombo)
//         {
//             animator.SetBool("isCombo", true);


//         }
//         else
//         {
//             animator.SetBool("isCombo", false);
//             // isAttack = false;
//         }
//     }

//     public void EndCombo()
//     {
//         isAttack = false;
//         isCombo = false;
//     }

//     public void TakeDamage(float damage)
//     {
//         hp -= damage;
//         if (hp <= 0)
//         {
//             Death();
//         }
//     }
//     public void Death()
//     {
        
//     }
// }
