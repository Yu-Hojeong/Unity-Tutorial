using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Vector3 returnPos = new Vector3(30, 3, 0);

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (this.transform.position.x <= -30f)
        {
            this.transform.position = returnPos;
        }
    }
}
