using UnityEngine;

public class ColliderEvents : MonoBehaviour
{
    public Animator anim;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            anim.SetTrigger("Fade");
        }
    }
}
