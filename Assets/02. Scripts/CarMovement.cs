using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;
    float ho;


    // Update is called once per frame
    void Update()
    {
        ho = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * ho * moveSpeed * Time.deltaTime;


    }

    void FixedUpdate()
    {
        carRb.linearVelocityX = ho * moveSpeed * Time.deltaTime;
        // carRb.velocity = new Vector2(ho * moveSpeed, carRb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("crash");
    }
}
