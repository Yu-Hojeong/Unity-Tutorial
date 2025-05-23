using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    public GameObject bulletPrefab;
    public Transform firePos;
    public float timer;
    public float cooldownTime = 1f;

    string playerTag = "Player";
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag(playerTag).transform;
    }

    // Update is called once per frame
    void Update()
    {
        turretHead.LookAt(targetTf);
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // 총알 생성
        }
    }
}


    
    
//     void Start() // 1번 실행 -> 무엇인가를 셋팅하는 기능
//     {
//         targetTf = GameObject.FindGameObjectWithTag("Player").transform;
//     }
    
//     void Update() // 무엇인가를 바라보는 기능
//     {
//         turretHead.LookAt(targetTf);

//         Instantiate(bulletPrefab, firePos.position, firePos.rotation);
//     }
    
// }