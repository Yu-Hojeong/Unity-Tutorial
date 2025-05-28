using UnityEngine;

public class CatController : MonoBehaviour
{
    Rigidbody2D catRb;
    public float jumpPower = 10f;
    bool isGround = false;
    int jumpCount = 0;
    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
                jumpCount++;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            jumpCount = 0;
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }  
    }
}
