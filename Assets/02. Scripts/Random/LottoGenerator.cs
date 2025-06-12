using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LottoGenerator : MonoBehaviour
{
    public List<int> intList = new List<int>();
    int shakeCount = 1000;


    void Awake()
    {
        for (int i = 1; i < 46; i++)
        {
            intList.Add(i);
        }   
    }

    IEnumerator Start()
    {
        for (int i = 0; i < shakeCount; i++)
        {
            int ranInt1 = Random.Range(0, intList.Count);
            int ranInt2 = Random.Range(0, intList.Count);

            var temp = intList[ranInt1];
            intList[ranInt1] = intList[ranInt2];
            intList[ranInt2] = temp;

            yield return new WaitForSeconds(0.01f);

        }
        List<int> resultGroup = new List<int>();
        for (int i = 0; i < 6; i++)
        {
            resultGroup.Add(intList[i]);
        }
        resultGroup.Sort();
        string resultNumber = $"이번주로또번호: {intList[0]}/{intList[1]}/{intList[2]}/{intList[3]}/{intList[4]}/{intList[5]}/";
        Debug.Log(resultNumber);
    }
}
