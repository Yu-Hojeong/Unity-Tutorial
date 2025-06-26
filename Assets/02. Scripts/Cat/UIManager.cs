using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


    public class UIManager : MonoBehaviour
    {
    public ScoreManager scoreManager;
        public GameObject playObj;
        public GameObject introUI;
        public TMP_InputField inputField;
        public TextMeshProUGUI catNameText;
        public Button startButton;
        public Button restartButton;
    

    void Start()
    {

        startButton.onClick.AddListener(OnStartButton);
        restartButton.onClick.AddListener(OnRestartButton);
    }

    public void OnStartButton()
    {

        catNameText.text = inputField.text;
        playObj.SetActive(true);
        introUI.SetActive(false);

        Debug.Log($"{catNameText.text} 입력");
        catNameText.text = inputField.text;
        scoreManager.isGameStart = true;
        

    }
    public void OnRestartButton()
    {
        
            string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        

    }
    }


// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;

// namespace Cat
// {
//     public class UIManager : MonoBehaviour
//     {
//         public GameObject playObj;
//         public GameObject introUI;
        
//         public TMP_InputField inputField;
//         public TextMeshProUGUI nameTextUI;
        
//         public Button startButton;

//         public void OnStartButton()
//         {
//             bool isInput = inputField.text == "";

//             if (isInput)
//             {
//                 Debug.Log("입력한 텍스트 없음");
//             }
//             else
//             {
//                 playObj.SetActive(true);
//                 introUI.SetActive(false);
                
//                 Debug.Log($"{nameTextUI} 입력");
//                 nameTextUI.text = inputField.text;
//             }
//         }
//     }
// }