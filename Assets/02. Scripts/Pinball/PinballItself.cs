using UnityEngine;

public class PinballItself : MonoBehaviour
{
    public PinballManager pinballManager;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("S10"))
        {
            Debug.Log("10점 획득");
            pinballManager.totalScore += 10;
        }
        else if (collision.gameObject.CompareTag("S20"))
        {
            Debug.Log("20점 획득");
            pinballManager.totalScore += 20;
        }
        else if (collision.gameObject.CompareTag("S30"))
        {
            Debug.Log("30점 획득");
            pinballManager.totalScore += 30;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GameOver"))
        {
            Debug.Log("게임종료");
            Debug.Log(pinballManager.totalScore);
        }
    }
}


// switch (other.gameObject.tag)
//         {
//             case "Score10":
//                 score = 10;
//                 break;
//             case "Score30":
//                 score = 30;
//                 break;
//             case "Score50":
//                 score = 50;
//                 break;
//         }
// pinballManager.totalScore += score;
//         Debug.Log($"{score}점 획득");