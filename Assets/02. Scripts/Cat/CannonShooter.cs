using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    public GameObject applePrefab;
    public Transform spawnPoint;
    public float launchForce = 10f;
    public float shootInterval = 2f;

    // 대포 움직임 관련 변수 추가
    public float moveRange = 2f;    // 대포가 움직일 수 있는 총 거리 (위아래)
    public float moveSpeed = 1f;    // 대포가 움직이는 속도

    private float nextShootTime;
    private Vector3 initialPosition; // 대포의 초기 위치

    void Start()
    {
        nextShootTime = Time.time;
        initialPosition = transform.position; // 대포의 현재 위치를 초기 위치로 저장
    }

    void Update()
    {
        // --- 대포 움직임 로직 추가 ---
        // Mathf.PingPong은 0에서 length까지 앞뒤로 반복되는 값을 반환합니다.
        // moveRange의 절반을 사용하여 초기 위치를 중심으로 위아래로 움직이도록 합니다.
        float newY = initialPosition.y + Mathf.PingPong(Time.time * moveSpeed, moveRange) - (moveRange / 2);
        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
        // -----------------------------

        if (Time.time >= nextShootTime)
        {
            ShootApple();
            nextShootTime = Time.time + shootInterval;
        }
    }

    void ShootApple()
    {
        if (applePrefab == null || spawnPoint == null)
        {
            Debug.LogError("Apple Prefab or Spawn Point is not assigned in CannonShooter script!");
            return;
        }

        GameObject apple = Instantiate(applePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = apple.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // spawnPoint의 '오른쪽' 방향으로 힘을 가함 (대포가 오른쪽을 향한다고 가정)
            // 대포가 왼쪽을 향한다면, Vector2.left * launchForce 로 변경
            // 또는 spawnPoint의 로컬 좌표계 x축 방향 (spawnPoint.right)을 사용하면 대포 회전에도 맞출 수 있습니다.
            rb.AddForce(spawnPoint.right * launchForce, ForceMode2D.Impulse);
        }
    }
}