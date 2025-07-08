using UnityEngine;

public class PushPlatform : MonoBehaviour
{
    Animator animator;
    Rigidbody2D targetRb;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            targetRb = collision.GetComponent<Rigidbody2D>();
            Invoke("PushCharacter", 1f);
        }
    }

    void PushCharacter()
    {
        targetRb.AddForceY(15f, ForceMode2D.Impulse);
        animator.SetTrigger("Push");
    }
}
