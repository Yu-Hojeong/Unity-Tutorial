using UnityEngine;

public class StudyComponent : MonoBehaviour
{

    public GameObject obj;
    public Mesh msh;
    public Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // obj = GameObject.Find("Main Camera");
        obj = GameObject.FindGameObjectWithTag("Player");

        obj.name = "cuuuuube";

        Debug.Log(obj.name); // 게임오브젝트의 이름
        Debug.Log(obj.tag); // 게임오브젝트의 태그
        Debug.Log(obj.transform.position); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log(obj.transform.rotation); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log(obj.transform.localScale); // 게임오브젝트의 Transform 컴포넌트의 크기
                                             // MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력하는 기능
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력하는 기능
        Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        // obj.GetComponent<MeshRenderer>().enabled = false;

        CreateCube();
        CreateCube("Hello World");

        // Destroy(obj,3f);
    }

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name);
        
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        
        obj.AddComponent<BoxCollider>();
    }
}


// using UnityEngine;

// public class StudyGameObject : MonoBehaviour
// {
//     public GameObject prefab;
    
//     void Start()
//     {
//         CreateAmongus();
//     }

//     public void CreateAmongus()
//     {
//         GameObject obj = Instantiate(prefab);
//         obj.name = "어몽어스 캐릭터";

//         Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");
        
//         Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");
        
//         Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : " +
//                   $"{obj.transform.GetChild(obj.transform.childCount - 1).name}");
//     }
    
// }


// using UnityEngine;

// public class StudyGameObject : MonoBehaviour
// {
//     public GameObject prefab;
    
//     void Start()
//     {
//         CreateAmongus();
//     }

//     public void CreateAmongus()
//     {
//         GameObject obj = Instantiate(prefab);
//         obj.name = "어몽어스 캐릭터";
        
//         Transform objTf = obj.transform;
//         int count = objTf.childCount;

//         Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        
//         Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        
//         Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");
//     }
    
// }