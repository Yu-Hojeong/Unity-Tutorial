using UnityEngine;
using UnityEngine.UI;

public class KCJoystick : MonoBehaviour
{
    Animator animator;
    Rigidbody2D knightRb;
    Vector3 inputDir;
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float jumpPower = 15f;
    [SerializeField] Button jumpButton;
    [SerializeField] Button attackButton;
    bool isGround;
    bool isAttack;
    bool isCombo;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
        // jumpButton.onClick.AddListener(Jump);
        // attackButton.onClick.AddListener(Attack);
    }
    void Update()
    {
        // InputKeyboard();
    }

    void FixedUpdate()
    {
        Move();
    }




    public void InputJoystick(float x, float y)
    {
        inputDir = new Vector3(x, y, 0).normalized;
        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);

        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }

    void Move()
    {
        if (inputDir.x != 0)
        {
            knightRb.linearVelocity = inputDir * moveSpeed;
        }
    }



    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Ground"))
    //     {
    //         animator.SetBool("isGround", true);
    //     }
    // }
    // void OnCollisionExit2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Ground"))
    //     {
    //         animator.SetBool("isGround", false);
    //     }
    // }

    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Monster"))
    //     {
    //         Debug.Log("Attacked");
    //     }    
    // }
    

    

    // void Jump()
    // {
    //     // if (Input.GetKeyDown(KeyCode.Space))
    //     // {
    //     animator.SetTrigger("Jump");
    //     knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);

    //     // }
    // }





    // void Attack()
    // {
    //     if (!isAttack)
    //     {
    //         isAttack = true;
    //         animator.SetTrigger("Attack");
    //     }
    //     else
    //     {
    //         isCombo = true;

    //     }

    // }

    // public void CheckCombo()
    // {
    //     if (isCombo)
    //     {
    //         animator.SetBool("isCombo", true);


    //     }
    //     else
    //     {
    //         animator.SetBool("isCombo", false);
    //         // isAttack = false;
    //     }
    // }

    // public void EndCombo()
    // {
    //     isAttack = false;
    //     isCombo = false;
    // }
}
