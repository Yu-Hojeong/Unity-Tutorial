using System;
using UnityEngine;

public class StudyCasting : MonoBehaviour
{
    int number1 = 1;
    float number2 = 10f;

    void Start()
    {
        number1 = (int)number2;

        Vector3 vec = new Vector3(10, 20, 30); //벡터 안 값은 플로트이다
        Vector3Int vecInt = new Vector3Int(10, 20, 30);


        Mathf.Floor(number2);
        Mathf.Ceil(number2);
        Mathf.Round(number2);

        string str1 = "123";
        string str2 = "456";

        string str3 = str1 + str2;

        int snum1 = int.Parse(str1);
        int snum2 = int.Parse(str2);
        Debug.Log(Convert.ToBoolean(number1));
    }
}
