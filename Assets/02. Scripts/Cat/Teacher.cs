using UnityEngine;

public class Teacher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
// IEnumerator EndingRoutine(bool isHappy)
//     {
//         yield return new WaitForSeconds(3.5f);
//         transform.parent.gameObject.SetActive(false); // PLAY 오브젝트 Off
        
//         videoManager.VideoPlay(isHappy);
        
//         fadeUI.SetActive(false);
//         gameOverUI.SetActive(false);
//         soundManager.audioSource.mute = true;
//         Debug.Log("영상 재생 완료");
//     }

//     using TMPro;
// using UnityEngine;

// namespace Cat
// {
//     public class GameManager : MonoBehaviour
//     {
//         public SoundManager soundManager;

//         public TextMeshProUGUI playTimeUI;
//         public TextMeshProUGUI scoreUI;

//         private static float timer;
//         public static int score; // 사과를 먹은 개수
//         public static bool isPlay;

//         void Start()
//         {
//             soundManager.SetBGMSound("Intro");
//         }

//         void Update()
//         {
//             if (!isPlay)
//                 return;

//             timer += Time.deltaTime;
//             playTimeUI.text = $"플레이 시간 : {timer:F1}초";
//             scoreUI.text = $"X {score}";
//         }

//         public static void ResetPlayUI()
//         {
//             timer = 0f;
//             score = 0;
//         }
//     }
// }

// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;

// namespace Cat
// {
//     public class UIManager : MonoBehaviour
//     {
//         public SoundManager soundManager;
        
//         public GameObject playObj;
//         public GameObject introUI;
//         public GameObject playUI;
        
//         public TMP_InputField inputField;
//         public TextMeshProUGUI nameTextUI;
        
//         public Button startButton;
//         public Button reStartButton;

//         void Awake()
//         {
//             playObj.SetActive(false);
//             introUI.SetActive(true);
//             playUI.SetActive(false);
//         }
        
//         void Start()
//         {
//             startButton.onClick.AddListener(OnStartButton);
//             reStartButton.onClick.AddListener(OnRestartButton);
//         }

//         public void OnStartButton()
//         {
//             bool isNoText = inputField.text == "";

//             if (isNoText)
//                 Debug.Log("입력한 텍스트 없음");
//             else
//             {
//                 nameTextUI.text = inputField.text;
//                 soundManager.SetBGMSound("Play");
                
//                 GameManager.isPlay = true;
                
//                 playObj.SetActive(true);
//                 playUI.SetActive(true);
//                 introUI.SetActive(false);
                
//             }
//         }

//         public void OnRestartButton()
//         {
//             GameManager.ResetPlayUI();
//             playObj.SetActive(true);
//         }
//     }
// }