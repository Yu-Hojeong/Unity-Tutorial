
using UnityEngine;

public class Apple : MonoBehaviour
{
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager를 찾을 수 없습니다.");
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scoreManager.appleScore += 1;
            Destroy(this.gameObject);
        }
    }
}
