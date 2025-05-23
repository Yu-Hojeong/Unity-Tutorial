using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;

    
    void Update()
    {
        transform.position += this.transform.forward * bulletSpeed * Time.deltaTime;
    }
}
