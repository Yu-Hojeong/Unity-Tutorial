using UnityEngine;
using UnityEngine.AI;

public class StudyRandom : MonoBehaviour
{
    void OnEnable()
    {
        int randNumber = Random.Range(0, 100); // 0~99
        float fRandNumber = Random.Range(0f, 100f); // 0~100
    }
}
