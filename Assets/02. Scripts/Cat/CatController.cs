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




// using System;
// using UnityEngine;
// using Cat; // 사운드 매니저가 있는 namespace

// public class CatController : MonoBehaviour
// {
//     public SoundManager soundManager; // public으로 설정했기 때문에 유니티 상에서 할당 예정
    
//     private Rigidbody2D catRb;
//     private Animator catAnim;
    
//     public float jumpPower = 30f;
//     public float limitPower = 25f;
    
//     public bool isGround = false;
    
//     public int jumpCount = 0;

//     void Start()
//     {
//         catRb = GetComponent<Rigidbody2D>();
//         catAnim = GetComponent<Animator>();
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 5)
//         {
//             catAnim.SetTrigger("Jump");
//             catAnim.SetBool("isGround", false);
//             jumpCount++; // 1씩 증가
//             soundManager.OnJumpSound();
//             catRb.AddForceY(jumpPower, ForceMode2D.Impulse);

//             if (catRb.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
//                 catRb.linearVelocityY = limitPower;
//         }

//         var catRotation = transform.eulerAngles;
//         catRotation.z = catRb.linearVelocityY * 2.5f;
//         transform.eulerAngles = catRotation;
        
//     }

//     private void OnCollisionEnter2D(Collision2D other)
//     {
//         if (other.gameObject.CompareTag("Ground"))
//         {
//             catAnim.SetBool("isGround", true);
//             jumpCount = 0;
//             isGround = true;
//         }
//     }

//     private void OnCollisionExit2D(Collision2D other)
//     {
//         if (other.gameObject.CompareTag("Ground"))
//         {
//             isGround = false;
//         }
//     }
// }



// using System.Collections;
// using UnityEngine;
// using UnityEngine.UI;

// public class FadeRoutine : MonoBehaviour
// {
//     public Image fadePanel; // 페이드 이미지
    
//     void Start()
//     {
//         StartCoroutine(FadeRoutineA(3, true)); // 3초동안 페이드 인
        
//         // StartCoroutine(FadeRoutineA(3, false)); // 3초동안 페이드 아웃
//     }
    
//     IEnumerator FadeRoutineA(float fadeTime, bool isFadeIn)
//     {
//         float timer = 0f;
//         float percent = 0f;
//         float value = 0f;
//         while (percent < 1f)
//         {
//             timer += Time.deltaTime;
//             percent = timer / fadeTime;
//             value = isFadeIn ? percent : 1 - percent;

//             fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, value);
//             yield return null;
//         }
//     }
// }


// using TMPro;
// using UnityEngine;

// public class GameManager : MonoBehaviour
// {
//     public TextMeshProUGUI playTimeUI;
//     private float timer;

//     void Update()
//     {
//         timer += Time.deltaTime;

//         playTimeUI.text = string.Format("플레이 시간 : {0:F0}초", timer);
//     }
// }