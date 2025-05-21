using System.Collections.Generic;
using UnityEngine;

public class Study_Array : MonoBehaviour
{
    int[] arrayNumber = new int[5];
    List<int> listNumber = new List<int>();
    void Start()
    {
        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");

        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        
        Debug.Log($"List data amount : {listNumber.Count}");
    }


    void Update()
    {
        
    }
}
