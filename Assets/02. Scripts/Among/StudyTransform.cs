using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
    void Update()
    {
        // 월드방향 z축
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        // 로컬방향 앞쪽
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        // 월드방향 앞쪽
        // transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;
        // 월드방향 회전
        // transform.rotation = quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        // 로컬방향 회전
        // transform.localRotation = quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); Space.Self 생략
        //특정위치 주변을 회전
        // transform.RotateAround(Vector3.zero특정, Vector3.up, rotateSpeed * Time.deltaTime);
        // transform.RotateAround(Vector3.zero특정, new Vector3(0f, 1f, 0f), rotateSpeed * Time.deltaTime);
    }
}
