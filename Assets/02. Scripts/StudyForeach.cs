using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] { "철수", "영희", "동수", "마이클", "존" };

    public string findName;

    void Start()
    {
        FindPerson(findName);
    }

    private void FindPerson(string name)
    {
        foreach (var person in persons)
        {
            if (person == name)
            {
                Debug.Log($"인원 중에 {name}이 존재합니다.");
            }
        }
    }
}


// using Unity.VisualScripting;
// using UnityEngine;

// public class Study_Invoke : MonoBehaviour
// {
//     public int count = 10;
    
//     void Start()
//     {
//         InvokeRepeating("Bomb", 0f, 1f);
//     }

//     private void Bomb()
//     {
//         Debug.Log($"현재 남은 시간 : {count}초");
//         count--;

//         if (count == 0)
//         {
//             Debug.Log("폭탄이 터졌습니다.");
//         }
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             CancelInvoke("Bomb");
//             Debug.Log("폭탄이 해제되었습니다.");
//         }
//     }
// }