using System.Collections;
using UnityEngine;

public class StartCoroutine : MonoBehaviour
{

    Coroutine runningCoroutine;

    void Start()
    {
        runningCoroutine = StartCoroutine(RoutineA());
        StopCoroutine(runningCoroutine);
        StopCoroutine("RoutineA");//둘다됨
        // Invoke("MethodA", 1f);
    }

    IEnumerator RoutineA()
    {
        yield return null; //1 frame wait
        yield return new WaitForSeconds(3f);
        Debug.Log("start crt");
        yield break;
    }

    void MethodA()
    {
        Debug.Log("ddd");
    }
    
}


// using System.Collections;
// using UnityEngine;

// public class Study_Coroutine : MonoBehaviour
// {
//     private bool isStop = false;
    
//     void Start()
//     {
//         StartCoroutine(BombRoutine());
//     }

//     IEnumerator BombRoutine()
//     {
//         int t = 10;
//         while (t > 0)
//         {
//             Debug.Log($"{t}초 남았습니다.");
//             yield return new WaitForSeconds(1f);
//             t--;

//             if (isStop)
//             {
//                 Debug.Log("폭탄이 해제되었습니다.");
//                 yield break;
//             }
//         }
        
//         Debug.Log("폭탄이 터졌습니다.");
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             isStop = true;
//         }
//     }
// }

//break 반복문탈출  yield break 코루틴 탈출