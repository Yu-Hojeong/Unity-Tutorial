using JetBrains.Annotations;
using UnityEngine;

public class NumKeypad : MonoBehaviour
{
    public string password;
    public string keypadNumber;

    public void OnInputNumber(string numString)
    {
        keypadNumber += numString;
        Debug.Log($"{numString} 압력 -> 현재입력: {keypadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keypadNumber == password)
        {
            Debug.Log("문열림");
        }
        else
        {
            Debug.Log("비밀번호 틀림");
            keypadNumber = "";
        }
    }
    
}
