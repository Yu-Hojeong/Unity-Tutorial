using System.Collections;
using TMPro;
using UnityEngine;

public class TypingText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textUI;
    [SerializeField] float typingSpeed = 0.1f;
    string currentText;

    void Awake()
    {
        currentText = textUI.text;
    }

    void OnEnable()
    {
        textUI.text = string.Empty;
        StartCoroutine(TypingRoutine());
    }



    IEnumerator TypingRoutine()
    {
        int textCount = currentText.Length;
        for (int i = 0; i < textCount; i++)
        {
            textUI.text += currentText[i];
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
