using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform target;
    public float smoothValue;
    public Vector3 startPos;
    public Vector3 targetPos;
    float timer, percent, lerpTime;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        timer += Time.deltaTime;
        percent = timer / lerpTime;

        // transform.position = Vector3.Lerp(transform.position, target.position, smoothValue);
        transform.position = Vector3.Lerp(startPos, targetPos, percent);

    }
}
