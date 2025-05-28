using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float returnPosX = 30f;
    public float randomPosY;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (this.transform.position.x <= -returnPosX)
        {
            randomPosY = Random.Range(-8f, -3.2f);
            this.transform.position = new Vector3(returnPosX, randomPosY, 0);
        }
    }
}
