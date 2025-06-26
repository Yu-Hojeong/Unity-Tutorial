using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    // public UIManager uIManager;
    public GameObject gameClear;
    float currentTime = 0;
    public int appleScore;
    public bool isGameStart;




    private void Update()
    {
        if (isGameStart)
        {
            currentTime += Time.deltaTime;
            timeText.text = string.Format("경과시간: {0:F2}", currentTime);
        }

        scoreText.text = string.Format("X {0}", appleScore);

        if (appleScore >= 3)
        {
            gameClear.SetActive(true);
        }

    }
}
