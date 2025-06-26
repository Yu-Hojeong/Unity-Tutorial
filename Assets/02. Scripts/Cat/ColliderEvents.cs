using UnityEngine;

public class ColliderEvents : MonoBehaviour
{
    public GameObject gameover;
    public Animator anim;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            gameover.SetActive(true);
            anim.SetTrigger("Fade");
        }
    }
}
